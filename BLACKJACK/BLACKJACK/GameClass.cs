using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLACKJACK
{
    public struct Card
    {
        public int iIndex;
        public int iShape;
        public bool bUse;
        public void Clear()
        {
            iIndex = -1;
            iShape = -1;
            bUse = false;
        }
    }

    public class CardStore
    {
        Card[] HasCard;
        const int cardShapeMax = 4;
        const int cardIndexMax = 13;
        public CardStore()
        {
            HasCard = new Card[cardIndexMax * cardShapeMax];

            for (int iShape = 0; iShape < cardShapeMax; iShape++)
            {
                for (int iIndex = 0; iIndex < cardIndexMax; iIndex++)
                {
                    HasCard[cardIndexMax * iShape + iIndex].Clear();
                }
            }
        }
        public void InitCard()
        {
            for (int iShape = 0; iShape < cardShapeMax; iShape++)
            {
                for (int iIndex = 0; iIndex < cardIndexMax; iIndex++)
                {
                    HasCard[cardIndexMax * iShape + iIndex].iShape = iShape;
                    HasCard[cardIndexMax * iShape + iIndex].iIndex = iIndex;
                    HasCard[cardIndexMax * iShape + iIndex].bUse = false;
                }
            }
        }
        public Card GetCard()
        {
            Card retCard = new Card();
            int nCnt = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Random ran = new Random();
                int iIndex = ran.Next(0, cardIndexMax * cardShapeMax);

                if (HasCard[iIndex].bUse == false)
                {
                    retCard = HasCard[iIndex];
                    HasCard[iIndex].bUse = true;
                    break;
                }
                nCnt++;
                if (nCnt > 100)
                    break;
            }
            return retCard;
        }
        public int CheckWin(int user, int computer)
        {
            // ret 1 : player
            //     2 : dealer
            //     0 : both
            int retWin = 0;
            //승자 판단부
            if (user == computer)
            {
                retWin = 0;
            }
            else if (user < 21)//21 이하이다.
            {
                if (computer == 21)
                {
                    retWin = 2;
                }
                else if (computer > 21)
                {
                    retWin = 1;
                }
                else//둘다 21이하다.
                {
                    if (user > computer)
                    {
                        retWin = 1;
                    }
                    else if (user < computer)
                    {
                        retWin = 2;
                    }
                    else
                    {
                        retWin = 0;
                    }
                }
            }
            else// player가 21보다 크다.
            {
                if (computer == 21)
                {
                    retWin = 0;
                }
                else if (computer < 21)
                {
                    retWin = 2;
                }
                else  // dealer가 21보다 크다
                {
                    if (user < computer)
                    {
                        retWin = 1;
                    }
                    else
                    {
                        retWin = 2;
                    }
                }
            }
            return retWin;
        }
    }

    public class Player
    {
        protected Card[] hasCard;
        protected const int cardMax = 5;
        protected int cardCount;
        protected bool isStand;

        public int CardCount
        {
            get { return cardCount; }
        }
        public bool IsStand
        {
            get { return isStand; }
            //set { isStand = value; }
        }

        public Player()
        {        
            hasCard = new Card[cardMax];
            for (int i = 0; i < cardMax; i++)
            {
                hasCard[i].Clear();
            }
            cardCount = 0;
            isStand = false;
        }

        public void Init()
        {
            for (int i = 0; i < cardMax; i++)
            {
                hasCard[i].Clear();
            }
            cardCount = 0;
            isStand = false;
        }

        public void Hit(Card card)
        {
            if (cardCount == cardMax)
                return;
            hasCard[CardCount] = card;
            cardCount++;
        }
        public void Stand()
        {
            isStand = true;
        }
        public virtual bool CheckStand()
        {
            // 게임을 중단할지를 선택한다.
            return true;
        }

        public void SetWin(bool win)
        {
            if (win == true)
                MessageBox.Show("Win!");
            else
                MessageBox.Show("Lose!");
        }

        public int CalcScore()
        {
            int retScore = 0;
            // 카드 A의 경우 1또는 11로 유리한 숫자를 선택한다.
            // JQK이면 10을 더함
            // 21을 최대값으로 가장 가까운 쪽이 승리한다.                     

            int iACount = 0;
            for (int iCard = 0; iCard < cardCount; iCard++)
            {
                // A = 0 , 10 = 9, J = 10, Q = 11, K = 12
                if (hasCard[iCard].iIndex == 10 || hasCard[iCard].iIndex == 11 || hasCard[iCard].iIndex == 12)//JQK이면 10을 더함
                {
                    retScore = retScore + 10;
                }
                else if (hasCard[iCard].iIndex == 0)//A이면 일단 skip
                {
                    // 일단 skip하고 추후 계산함.
                    iACount++;
                }
                else// 1~10일경우 그대로 더함 
                {
                    retScore = retScore + (hasCard[iCard].iIndex + 1);
                }
            }

            // A에 대한 판정 1 or 11
            if (iACount > 0)
            {
                if ((retScore <= 10) && (iACount == 1))
                {
                    retScore = retScore + 11;
                }
                else
                {
                    retScore = retScore + (1 * iACount);
                }
            }

            return retScore;
        }

        public Card GetCard(int iIndex)
        {
            Card retCard = new Card();
            if (iIndex < cardCount)
                retCard = hasCard[iIndex];
            return retCard;
        }
    }

    public class User : Player
    {
        public override bool CheckStand()
        {
            return true;
        }
    }

    public class Computer : Player
    {
        public override bool CheckStand()
        {
            bool retStand = false;

            int totalScore = CalcScore();
           
            if (totalScore >= 16) // 16점 이상이면 승률이 높으므로 stand
            {
                retStand = true;
            }
            else
            {
                retStand = false;  // 아닐경우 hit
            }

            return retStand;
        }
    }

    public class GameManager
    {
        public CardStore cardStore;
        public Player user;
        public Player computer;
        public bool showResult;

        public GameManager()
        {
            cardStore = new CardStore();
            user = new User();
            computer = new Computer();
        }

        public void Start()
        { 
            cardStore.InitCard();
            computer.Init();
            user.Init();
            showResult = false;

            computer.Hit(cardStore.GetCard());
            computer.Hit(cardStore.GetCard());

            user.Hit(cardStore.GetCard());
            user.Hit(cardStore.GetCard());
        }

        public void Hit()
        {
            user.Hit(cardStore.GetCard());

            if (computer.IsStand == true)
            {
                ;
            }
            else
            {
                if (computer.CheckStand() == true)
                    computer.Stand();
                else
                    computer.Hit(cardStore.GetCard());
            }
        }

        public void Stand()
        {
            user.Stand();

            if (computer.IsStand == true)
            {
                ;
            }
            else
            {
                while (true)
                {
                    if (computer.CardCount >= 5)
                    {
                        break;
                    }
                    else
                    {
                        if (computer.CheckStand() == true)
                        {
                            computer.Stand();
                            break;
                        }
                        else
                            computer.Hit(cardStore.GetCard());
                    }
                    System.Threading.Thread.Sleep(500);

                }
            }

            int iWin = cardStore.CheckWin(user.CalcScore(), computer.CalcScore());
            if (iWin == 1)
            {
                user.SetWin(true);
            }
            else if (iWin == 2)
            {
                user.SetWin(false);
            }

            showResult = true;
        }
    }
}

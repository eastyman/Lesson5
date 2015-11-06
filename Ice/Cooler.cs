
namespace Ice
{
    public class Cooler
    {
        private bool state;
        private int beerQuantity;
        private FrostLevel frost;
        private string stateMessage;
        public Cooler(bool state, int beerQuantity, FrostLevel frost)
        {
            this.state = state;
            this.beerQuantity = beerQuantity;
            this.frost = frost;
            this.stateMessage = " ";
        }
        public void On()
        {
            if (!state)
            {
                state = true;
                stateMessage = " ";
                frost = FrostLevel.Normal;
            }
            
        }

        public void Off()
        {
            state = false;
            frost = FrostLevel.Warmy;
        }

        public void GetBeers(int quantity)
        {

            if (beerQuantity - quantity >= 0)
            {
                beerQuantity = beerQuantity - quantity;
                stateMessage = " ";
            }
            
        }

        public void PutBeers(int quantity)
        {

            beerQuantity = beerQuantity + quantity;
            stateMessage = " ";

        }

        public void SetNormalFrost()
        {
            if (state)
            {
                frost = FrostLevel.Normal;
            }
            else
            {
                stateMessage = "Режим не меняется, холодильник выключен";
            }

        }
        public void SetUkrainianWinterFrost()
        {
            if (state)
            {
                frost = FrostLevel.UkrainianWinter;
            }
            else
            {
                stateMessage = "Режим не меняется, холодильник выключен";
            }
        }

        public void SetArcticIceFrost()
        {
            if (state)
            {
                frost = FrostLevel.ArcticIce;
            }
            else
            { 
                stateMessage = "Режим не меняется, холодильник выключен";
            }
        }

        public string Info()
        {
            string state;
            if (this.state)
            {
                state = "Вкл";
            }
            else
            {
                state = "Выкл";
            }
            
            string frostLev=" ";
            
            switch (this.frost)
            {
                case FrostLevel.Normal:
                    {
                        frostLev = "Норма";
                        break;
                    }
                case FrostLevel.Cold:
                    {
                        frostLev = "Холодно";
                        break;
                    }
                case FrostLevel.UkrainianWinter:
                    {
                        frostLev = "Холодно, как зимой в Украине";
                        break;
                    }
                case FrostLevel.ArcticIce:
                    {
                        frostLev = "Продукты превратились в лёд";
                        break;
                    }
                case FrostLevel.Warmy:
                    {
                        frostLev = "Продукты медленно но уверенно подогреваются";
                        break;
                    }
            }
            return "Состояние: " + state + ", уровень холода: " + frostLev + ", количество пива: " + beerQuantity + " " + stateMessage;
        }
    }
}

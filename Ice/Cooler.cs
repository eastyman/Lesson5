
namespace Ice
{
    public class Cooler
    {
        private bool state;
        private int beerQuantity;
        private FrostLevel frost;
        public Cooler(bool state, int beerQuantity, FrostLevel frost)
        {
            this.state = state;
            this.beerQuantity = beerQuantity;
            this.frost = frost;
        }
        public void On()
        {
            state = true;
        }

        public void Off()
        {
            state = false;
        }

        public void GetBeers(int quantity)
        {
            if (beerQuantity - quantity >= 0)
            {
                beerQuantity = beerQuantity - quantity;
            }
        }

        public void PutBeers(int quantity)
        {

            beerQuantity = beerQuantity + quantity;

        }

        public void SetNormalFrost()
        {
            frost = FrostLevel.Normal;
        }
        public void SetUkrainianWinterFrost()
        {
            frost = FrostLevel.UkrainianWinter;
        }

        public void SetArcticIceFrost()
        {
            frost = FrostLevel.ArcticIce;
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
            }
            return "Состояние: " + state + ", уровень холода: " + frostLev + ", количество пива: " + beerQuantity;

        }

    }
}

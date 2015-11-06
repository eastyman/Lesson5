using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.level = frost;
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
            string frostLev;
            switch (this.FrostLevel)
            {
                case FrostLevel.Normal:
                    {
                        frostLev = "Норма";
                    }
                case FrostLevel.Cold:
                    {
                        frostlev = "Холодно";
                    }
                case FrostLevel.UkrainianWinter:
                    {
                        frostLev = "Холодно, как зимой в Украине";
                    }
                case FrostLevel.ArcticIce:
                    {
                        frostLev = "Продукты превратились в лёд";
                    }
            }
            return "Состояние: " + state + ", уровень холода: " + frostLev + ", количество пива: " +  beerQuantity; 

        }   
        
    }     
 }


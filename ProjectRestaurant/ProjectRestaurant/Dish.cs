using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRestaurant
{
    class Dish
    {
        private string name;
        private string type;
        private int price;
        private int timeCooking;
        private string description;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                
               
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0) 
                    price = value;
            }
        }
        public int TimeCooking
        {
            get
            {
                return timeCooking;
            }
            set
            {
                if (value >= 0)
                    timeCooking = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public Dish(string name, string type, int price, int timeCooking, string description)
        {
            this.name = name;
            this.type = type;
            this.price = price;
            this.timeCooking = timeCooking;
            this.description = description;
        }
        public Dish()
        {
            name = "Не указано";
            type = "Не определён";
            price = 0;
            timeCooking = 0;
            description = "";
        }
        
    }

}

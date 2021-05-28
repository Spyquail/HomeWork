using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectResraurantWinForm
{
    class Dish
    {
        public Dish(int Id, string name, string type, int price, int timeCooking, string description, string pictureDish)
        {
            this.Id = Id;
            this.DishName = name;
            this.TypeOfDish = type;
            this.PriceOfDIsh = price;
            this.CookingTime = timeCooking;
            this.DescriptionDish = description;
            this.PictureDish = pictureDish;
        }
       
        public string DishName { get; set; }
        public string TypeOfDish { get; set; }
        public int PriceOfDIsh { get; set; }
        public int CookingTime { get; set; }
        public string DescriptionDish { get; set; }
        public string PictureDish{ get; set; }
        public int Id { get; set; }


    }
}

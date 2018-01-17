using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_036
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Pontiac";
            myNewCar.Model = "Fire Bird";
            myNewCar.Year = 1970;
            myNewCar.Color = "Black";

            //double marketValueOfCar = determineMarketValue(myNewCar);
            double marketValueOfCar = myNewCar.DetermineMarketValue();

            resultLabel.Text = String.Format("{0} - {1} - {2} - {3}. Market Value of car: {4:C}", myNewCar.Make, myNewCar.Model, myNewCar.Year, myNewCar.Color, marketValueOfCar);
        }

        /*
        private double determineMarketValue(Car car)
        {
            double carValue = 100.00;
            if(car.Year > 1990)
            {
                carValue = 10000.00;
            }
            else
            {
                carValue = 2000.00;
            }
            return carValue;
        }
        */
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue = 100.00;
            if (Year > 1990)
            {
                carValue = 10000.00;
            }
            else
            {
                carValue = 2000.00;
            }
            return carValue;
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore
{
    public class Queries
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        //adding data to table columns
        public void AddNewTour()
        {
            var newTour = new Tour()
            {
                Description = "Visit the Sandy beaches of Diani",
                Duration = "Mine",
                Title = "Customer",
                Price = 50000,
                
           

            };
            //add to tables

            context.Tours.Add(newTour);
            context.SaveChanges();//save

        }
        //fetching data from table
        public void GetALLTours() 
        {
            var tours = context.Tours.ToList();
            foreach (var tour in tours)
            {
                Console.WriteLine($"{tour.Title}-- {tour.Description}-- {tour.Duration}");
            }
           
        }
        public void GetOneTour() 
        {
            //var tour = context.Tours.Find(id);
            var tours = context.Tours.Where(t=>t.Price>50000).ToList();
            foreach (var tour in tours)
            {
                Console.WriteLine($"{tour.Title}-- {tour.Description}-- {tour.Price}");
            }
        }
        public void GetOneTourandOrder() 
        { 
            var tours =context.Tours.Where(t=>t.Price>5000).OrderByDescending(c=>c.Duration).ThenByDescending(c=>c.Price).ToList();
            foreach (var tour in tours)
            {
                Console.WriteLine($"{tour.Title}-- {tour.Description}--{tour.Duration}-- {tour.Price}");
            }
        }
        public void UpdateTour(int id)
        {
            Tour tour = context.Tours.Find(id);
            if(tour != null )
            {
                tour.Description = "Visit the beautiful escarpments of Mt longonot";
                

            }
            else
            {
                return;
            }
            //saving changes
            context.SaveChanges();
            //loop through again
            var tours = context.Tours.ToList();
            foreach (var tour1 in tours)
            {
                Console.WriteLine($"{tour1.Title}-- {tour1.Description}-- {tour1.Duration}--- {tour1.Price}");
            }
        }
        public void DeleteTour(int id)
        {
            //check if the item exists
            try
            {
                Tour tour = context.Tours.Find(id);
                if(tour != null)
                {
                    context.Tours.Remove(tour);
                    context.SaveChanges();
                }
                var tours = context.Tours.ToList();
                foreach (var tour1 in tours)
                {
                    Console.WriteLine($"{tour1.Title}-- {tour1.Description}-- {tour1.Duration}--- {tour1.Price}");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine( ex.Message);
            }
        }
    }
}

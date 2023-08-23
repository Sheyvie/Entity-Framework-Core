//using Efcore;

//ApplicationDbContext context = new ApplicationDbContext();

//context.Database.EnsureCreated();

using Efcore;
using System.Net.Quic;

Queries queries = new Queries();
//queries.AddNewTour();
//queries.GetALLTours();
//queries.GetOneTour();
//queries.GetOneTourandOrder();
//queries.UpdateTour();
queries.DeleteTour(5);
using System;
using System.Collections.Generic;
using System.Data.Entity;
using snooker1.Models;
using System.Linq;
namespace snooker1.Repos
{
    public class SnookerDBInitialiser : DropCreateDatabaseIfModelChanges<SnookerContext>
    {

        protected override void Seed(SnookerContext context)
        {

            Player player1 = new Player()    {  Name = "paul" };  context.Players.Add(player1);

                       
            context.SaveChanges();


           // base.Seed(context);
        }

       

    }
}
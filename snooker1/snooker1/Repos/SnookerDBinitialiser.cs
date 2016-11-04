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

            Player player1 = new Player()    {  ID = 1, Name = "Paul" };  context.Players.Add(player1);
            Player player2 = new Player() { ID = 1, Name = "Ronnie" }; context.Players.Add(player2);



            Frame f1 = new Frame() { FrameWon = true, Player = player1 }; context.Frames.Add(f1);
            Frame f2 = new Frame() { FrameWon = true, Player = player2}; context.Frames.Add(f2);

            List<Frame> f1L = new List<Frame>();
            f1L.Add(f1);
            f1L.Add(f2);

            List<Player> pl1 = new List<Player>();
            pl1.Add(player1);
            pl1.Add(player2);

            Match m1 = new Match() { Date = DateTime.Parse("04-11-2016"), Frames = f1L, Players = pl1, FramesLost = 2, FramesWon = 3 , MatchResultWin = true, ID = 1 };
            context.Matches.Add(m1);           


            context.SaveChanges();


          // base.Seed(context);
        }

       

    }
}
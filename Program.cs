using System;
using System.Collections.Generic;

namespace AngularFirstSteps
{
    class Program
    {

        static void Main(string[] args)
        {

            List<Promoter> promoters = new List<Promoter>
            {
                new XSClubPromoter("Jonny", "Depp", 123456789),
                new XSClubPromoter("Dwayne", "Johnson", 987654321),
                new OmniaClubPromoter("Bruce", "Lee", 134679825)
            };

            foreach (var promoter in promoters)
            {
                promoter.Promote();
            }

            List<Writer> writers = new List<Writer>
            {
                new BlogWriter("Robert", "Kyjosaki"),
                new BookWriter("Will", "Smith"),
                new BookWriter("Barak", "Obama")
            };

            foreach (var writer in writers)
            {
                writer.Write();
            }

            List<BodyBuilder> bodybuilders = new List<BodyBuilder>
            {
                new XSClubPromoter("Dwayne", "Johnson", 987654321),
                new BlogWriter("Robert", "Kyjosaki")
            };

            foreach (var bodybuilder in bodybuilders)
            {
                bodybuilder.Workout();
            }

            List<Vlogger> vloggers = new List<Vlogger>
            {
                new XSClubPromoter("Dwayne", "Johnson", 987654321),
                new BlogWriter("Robert", "Kyjosaki"),
                new BookWriter("Barak", "Obama")
            };

            foreach (var vlogger in vloggers)
            {
                vlogger.Vlog();
            }

        }

        static void ShowMeHowYouPromote(Promoter promoters)
        {
            promoters.Promote();
        }

        static void ShowMeHowYouWrite(Writer writers)
        {
            writers.Write();
        }

        static void ShowMeHowYouWorkout(BodyBuilder bodybuilders)
        {
            bodybuilders.Workout();
        }

        static void ShowMeHowYouVlog(Vlogger vloggers)
        {
            vloggers.Vlog();
        }

    }
}

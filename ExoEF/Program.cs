// See https://aka.ms/new-console-template for more information
using ExoEF.Domain;
using ExoEF.Entities;
using Microsoft.EntityFrameworkCore;

DataContext dc = new DataContext();


#region 3. Ajouter film
//Movie movie = new Movie()
//{
//    Title = "“Pacific Rim",
//    Actor = "Charlie Hunnam",
//    Director = "Guillermo Del Toro",
//    Genre = "Action",
//    YearRelease = 2013
//};

//dc.Movies.Add(movie);
//dc.SaveChanges();
//Console.WriteLine("Film ajouté");

#endregion

#region 4. Select tous les films avant 2001

//foreach (var movie in dc.Movies.Where(m => m.YearRelease < 2001))
//{
//    Console.WriteLine($"{movie.Title} | {movie.YearRelease}");
//}

#endregion

#region 5. Mettre à jour film 

//var movieToUpdate = dc.Movies.Where(m => m.Title.Contains("Star Wars"));

//try
//{
//    foreach (var movie in movieToUpdate)
//    {
//        movie.Actor = "Harrison Ford";
//    }
//    dc.SaveChanges();
//    Console.WriteLine("Update réussie");

//}
//catch (DbUpdateException ex)
//{

//    Console.WriteLine("Erreur");
//    Console.WriteLine(ex.Message);

//}




#endregion

#region 6. Supprimer films

//var moviesToDelete = dc.Movies.Where(m => m.Actor == "Charlie Hunnam");

//try
//{
//    foreach (var movie in moviesToDelete)
//    {
//        if (movie is Movie)
//        {
//            dc.Remove(movie);
//        }
//    }
//    dc.SaveChanges();
//    Console.WriteLine("Delete réussi");
//}
//catch (DbUpdateException ex)
//{

//    Console.WriteLine("Erreur");
//    Console.WriteLine(ex.Message);
//}
#endregion


//try
//{
//Movie m = new Movie()
//{
//    Title = "eee",
//    DirectorID = 1,
//    YearRelease = 1985,
//    Genre = "Action"

//};
//dc.Movies.Add(m);
//dc.SaveChanges();
//ActorMovie movie = new ActorMovie()
//{
//    ActorId = 1,
//    MovieId = 11,
//};
//dc.ActorMovie.Add(movie);
//dc.SaveChanges();

//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}
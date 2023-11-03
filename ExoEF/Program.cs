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

//var selectTest = dc.Movies.Join(dc.Directors, m => m.DirectorID, d => d.personId, (m, d) => new { MovieName = m.Title, DirectorName = d.FirstName + " " + d.LastName });

//foreach (var val in selectTest)
//{
//    Console.WriteLine($"Director {val.DirectorName} has created {val.MovieName}");
//}

//List<Director> dList = dc.Directors.ToList();
//List<Movie> mList =  dc.Movies.ToList();

//var t = dList.GroupJoin(mList, d => d.personId, m => m.DirectorID, (d, m) => new { DirectorName = d.LastName + " " + d.FirstName, MoviesRealised = m });

//foreach (var d in t)
//{
//    Console.WriteLine($"Director name : {d.DirectorName} has realised :  " );

//    if (d.MoviesRealised.Count() > 0)
//    {
//        foreach (var m in d.MoviesRealised)
//        {
//        Console.WriteLine($"{m.Title}");
//        }
//    } else
//    {
//        Console.WriteLine("No movie found");
//    }
//}

//var actorsAndMovies = dc.Actors.Join(dc.ActorMovie, a => a.personId, am => am.ActorId, (a, am) => new { a , am })
//    .Join(dc.Movies, am => am.am.MovieId, m => m.MovieId, (am,m ) => new { ActorName = am.a.FirstName + " " + am.a.LastName, Movies = m.Title });

//foreach (var actMov in actorsAndMovies)
//{
//    Console.WriteLine($"{actMov.ActorName} has played in {actMov.Movies}");
//}
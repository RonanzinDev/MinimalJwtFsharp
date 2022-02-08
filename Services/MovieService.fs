namespace MinimalJwt.Services

open MinimalJwt.Services.IMovieService
open MinimalJwt.Repositories.MovieRepository
open System.Linq
open MinimalJwt.Models.Movie

type MovieService() =
    interface IMovieService with
        member this.Create(movie) =
            movies.Append(movie) |> ignore
            movie

        member this.Get(id) =
            let movie =
                movies.FirstOrDefault(fun o -> o.id = id)

            match movie with
            | x -> Some(x)

        member this.List() = movies

        member this.Update(newMovie) =
            let oldMovie =
                movies.FirstOrDefault(fun o -> o.id = newMovie.id)

            if oldMovie.Equals(null) then
                failwith "Dont find the movie"
            else
                let id = oldMovie.id
                let cout = movies.Length + 1
                let newid = id + cout

                { title = newMovie.title
                  description = newMovie.description
                  ratio = newMovie.ratio
                  id = newid }

        member this.Delete(id) =
            let oldMovie =
                movies.FirstOrDefault(fun o -> o.id = id)

            if oldMovie.Equals(null) then
                false
            else
                true

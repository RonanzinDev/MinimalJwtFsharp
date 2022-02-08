open Microsoft.AspNetCore.Builder
open System
open MinimalJwt.Models.Movie
open MinimalJwt.Services
open MinimalJwt.Services.IMovieService

let builder = WebApplication.CreateBuilder()
let app = builder.Build()

let hello = Func<string>(fun () -> "Hello world")

let ms = new MovieService()
let impl: IMovieService = (ms :> IMovieService)

let movies =
    Func<Option<Movie>>(fun () -> impl.Get(2))

app.MapGet("/", hello) |> ignore
app.MapGet("/movies", movies) |> ignore

app.Run()

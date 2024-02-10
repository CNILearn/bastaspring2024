﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using GetResults = System.Threading.Tasks.Task<Microsoft.AspNetCore.Http.HttpResults.Results<Microsoft.AspNetCore.Http.HttpResults.Ok<MinimalAPI.Book>, Microsoft.AspNetCore.Http.HttpResults.NotFound>>;

namespace MinimalAPI;

public static class BookEndpoints
{
    public static void MapBookEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Book").WithTags(nameof(Book));

        group.MapGet("/", async (BooksContext db) =>
        {
            return await db.Book.ToListAsync();
        })
        .WithName("GetAllBooks")
        .WithOpenApi();

        group.MapGet("/{id}", async GetResults (int id, BooksContext db) =>
        {
            return await db.Book.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Book model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetBookById")
        .WithOpenApi();

        group.MapGet("/query", (string? one = default, string? two = default, int x = 0, CancellationToken cancellationToken = default) =>
        {
            string result = $"one = {one}, two = {two}, x: {x}";
            return TypedResults.Ok(result);
        })
        .WithName("Query")
        .WithOpenApi();
        

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Book book, BooksContext db) =>
        {
            var affected = await db.Book
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Id, book.Id)
                    .SetProperty(m => m.Title, book.Title)
                    .SetProperty(m => m.Publisher, book.Publisher)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateBook")
        .WithOpenApi();

        group.MapPost("/", async (Book book, BooksContext db, CancellationToken cancellationToken = default) =>
        {
            db.Book.Add(book);
            await db.SaveChangesAsync(cancellationToken);
            return TypedResults.Created($"/api/Book/{book.Id}",book);
        })
        .WithName("CreateBook")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, BooksContext db) =>
        {
            var affected = await db.Book
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteBook")
        .WithOpenApi();
    }
}

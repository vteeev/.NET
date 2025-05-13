using Microsoft.EntityFrameworkCore;
using BookApi.Models;
using BookApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracja EF Core z SQLite
builder.Services.AddDbContext<BooksDbContext>(options =>
    options.UseSqlite("Data Source=books.db"));

var app = builder.Build();

// Automatyczne tworzenie bazy danych
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<BooksDbContext>();
    db.Database.EnsureCreated();
}

// Pobierz wszystkie książki
app.MapGet("/api/books", async (BooksDbContext db) =>
    await db.Books.ToListAsync());

// Pobierz książkę po ID
app.MapGet("/api/books/{id}", async (int id, BooksDbContext db) =>
    await db.Books.FindAsync(id) is Book book ? Results.Ok(book) : Results.NotFound());

// Dodaj nową książkę
app.MapPost("/api/books", async (Book book, BooksDbContext db) =>
{
    db.Books.Add(book);
    await db.SaveChangesAsync();
    return Results.Created($"/api/books/{book.Id}", book);
});


// Zaktualizuj istniejącą książkę
app.MapPut("/api/books/{id}", async (int id, Book input, BooksDbContext db) =>
{
    var book = await db.Books.FindAsync(id);
    if (book is null) return Results.NotFound();

    book.Title = input.Title;
    book.Author = input.Author;
    book.PublishedYear = input.PublishedYear;
    book.IsRead = input.IsRead;

    await db.SaveChangesAsync();
    return Results.Ok(book);
});

// Usuń książkę
app.MapDelete("/api/books/{id}", async (int id, BooksDbContext db) =>
{
    var book = await db.Books.FindAsync(id);
    if (book is null) return Results.NotFound();

    db.Books.Remove(book);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.Run();
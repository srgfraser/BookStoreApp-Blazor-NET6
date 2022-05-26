using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Author;
using BookStoreApp.API.Models.Book;

namespace BookStoreApp.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<Author, AuthorReadOnlyDto>(); 
            
            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
            CreateMap<Book, BookDetailsDto>()
                .ForMember(bDto => bDto.AuthorName, b => b.MapFrom(m => $"{m.Author.FirstName} {m.Author.LastName}"));
            CreateMap<Book, BookReadOnlyDto>()
                .ForMember(bDto => bDto.AuthorName, b => b.MapFrom(m => $"{m.Author.FirstName} {m.Author.LastName}"));
        }
    }
}

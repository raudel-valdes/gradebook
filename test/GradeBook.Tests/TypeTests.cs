using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {   
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

            //Verifies that two ojects are not the same instance
            Assert.NotSame(book1, book2);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }      

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {   
            var book1 = GetBook("Book 1");

            //book2 will have the same pointer value as book1
            var book2 = book1;

            //Verifies that two objects are the same instance
            Assert.Same(book1, book2);

            //this is the long  equivalent way of Assert.Same
            Assert.True(object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name) 
        {
            throw new BookTests(name);
        }
    }
}

//In C# when you pass a parameter to a method you are 100% of the
//the times passing by value
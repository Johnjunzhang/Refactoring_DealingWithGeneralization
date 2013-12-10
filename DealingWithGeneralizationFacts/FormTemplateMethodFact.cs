using DealingWithGeneralization.FormTemplateMethod;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class FormTemplateMethodFact
    {
        [Fact]
        public void should_get_ascii_statement_for_customer()
        {
            const string expectedStatement = "Rental Record for Kent\n100\n100\nAmount owed is 200\n";
            var asciiCustomer = new AsciiCustomer("Kent");
            asciiCustomer.AddRentals(new Rental());
            asciiCustomer.AddRentals(new Rental());
            var statement = asciiCustomer.Statement();
            Assert.Equal(expectedStatement, statement);
        }

        [Fact]
        public void should_get_html_statement_for_customer()
        {
            const string expectedStatement = "<H1>Rentals for <EM>Kent</EM></H1><P>\n: 100<BR>\n: 100<BR>\n<P>You owe <EM>200</EM><P>\n";
            var htmlCustomer = new HtmlCustomer("Kent");
            htmlCustomer.AddRentals(new Rental());
            htmlCustomer.AddRentals(new Rental());
            var statement = htmlCustomer.Statement();
            Assert.Equal(expectedStatement, statement);
        }
    }
}
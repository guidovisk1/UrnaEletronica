using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UrnaEletronica.Domains.ValueObjects;
using Xunit;

namespace UrnaEletronica.Tests.ValueObjects
{
    public sealed class NomeTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("Ab")]
        [InlineData("     ")]

        public void DeveRetornar_Erro_Quando_PrimeiroNome_EhInvalido(string primeiroNome)
        {
            var name = new Nome(primeiroNome, "Messi");

            Assert.False(name.IsValid);
        }

        [Theory]
        [InlineData("")]
        [InlineData("Abc")]
        [InlineData("     ")]
        public void DeveRetornar_Erro_Quando_UltimoNome_EhInvalido(string sobrenome)
        {
            var name = new Nome("Lionel", sobrenome);

            Assert.False(name.IsValid);
        }

    }
}

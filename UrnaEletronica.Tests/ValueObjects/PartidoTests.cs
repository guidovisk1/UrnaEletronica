using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domains.ValueObjects;
using Xunit;

namespace UrnaEletronica.Tests.ValueObjects
{
    public sealed class PartidoTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("Ab")]

        public void DeveRetornar_Erro_Quando_NomePartido_EhInvalido(string nomePartido)
        {
            var name = new Partido(nomePartido,new DateOnly(2005,10,11),"pl" );

            Assert.True(name.IsValid);
        }

    }
}

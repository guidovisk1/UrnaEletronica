using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domains.Entities;
using UrnaEletronica.Domains.ValueObjects;

namespace UrnaEletronica.Infra.Data.Context;

internal static class InitialData
{
    internal static List<Candidato> Candidatos
        = new()
        {
            Lula, Ciro, Bolsonaro
        };

    #region Partidos
    private static Partido PT = new Partido("Partido dos Trabalhadores", new DateOnly(1980, 02, 10), "PT");
    private static Partido PL = new Partido("Partido Liberal", new DateOnly(1985, 03, 12), "PL");
    private static Partido PDT = new Partido("Partido Democrático Trabalhista", new DateOnly(1979, 06, 17), "PDT");
    #endregion

    #region Lula
    private static Nome LulaNome = new Nome("Luis Inacio", "Lula da Silva");
    private static Idade LulaIdade = new Idade(70);
    private static Candidato Lula = new Candidato(LulaNome, LulaIdade, PT);
    #endregion
    #region
    private static Nome CiroNome = new Nome("Ciro", "Gomes");
    private static Idade CiroIdade = new Idade(71);
    private static Candidato Ciro = new Candidato(CiroNome, CiroIdade, PDT  );
    #endregion

    #region Bolsonaro
    private static Nome BolsoNome = new Nome("Jair Messias", "Bolsonaro");
    private static Idade BolsoIdade = new Idade(72);
    private static Candidato Bolsonaro = new Candidato(BolsoNome, BolsoIdade, PL);
    #endregion
}
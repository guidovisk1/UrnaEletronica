
using UrnaEletronica.Domains.Entities;
using UrnaEletronica.Domains.ValueObjects;

namespace UrnaEletronica.Infra.Data.Context;

public static class InitialData
{
    //internal static List<Candidato> Candidatos
    //    = new()
    //    {
    //        Lula, Ciro, Bolsonaro
    //    };

    #region Partidos
    public static Partido PT = new Partido("Partido dos Trabalhadores", new DateOnly(1980, 02, 10), "PT");
    public static Partido PL = new Partido("Partido Liberal", new DateOnly(1985, 03, 12), "PL");
    public static Partido PDT = new Partido("Partido Democrático Trabalhista", new DateOnly(1979, 06, 17), "PDT");
    #endregion

    #region Lula
    public static Nome LulaNome = new Nome("Luis Inacio", "Lula da Silva");
    public static Idade LulaIdade = new Idade(70);
    public static Candidato Lula = new Candidato(LulaNome, LulaIdade, PT);
    #endregion

    #region Ciro
    public static Nome CiroNome = new Nome("Ciro", "Gomes");
    public static Idade CiroIdade = new Idade(71);
    public static Candidato Ciro = new Candidato(CiroNome, CiroIdade, PDT  );
    #endregion

    #region Bolsonaro
    public static Nome BolsoNome = new Nome("Jair Messias", "Bolsonaro");
    public static Idade BolsoIdade = new Idade(72);
    public static Candidato Bolsonaro = new Candidato(BolsoNome, BolsoIdade, PL);
    #endregion
}
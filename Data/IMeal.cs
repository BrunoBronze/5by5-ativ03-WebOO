using System.Collections.Generic;
using Model;

namespace Data
{
    public interface IMeal
    {
        bool Insert(Meal refeicao);
        List<Meal> Select();
        bool Remover(int id);
        decimal FullValue(int Id);
    }
}

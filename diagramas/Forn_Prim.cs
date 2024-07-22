namespace Diagamas;

public partial class Forn_Prim(

    Public Forn_Prim()
    {
        Int64 Id;
        String Fornecedor;
        String MateriaPrima;
        String Preco;
    }

    private void SetId(Int64 i)
    {
        Id = i;
    }

    public string GetId()
    {
        return Id;
    }

    private void SetFornecedor(String f)
    {
        Fornecedor = f;
    }

    public string GetFornecedor()
    {
        return Fornecedor;
    }

    private void SetMateriaPrima(String mp)
    {
        MateriaPrima = mp;
    }

    public string GetMateriaPrima()
    {
        return MateriaPrima;
    }


    private void SetPreco(String p)
    {
        Senha = p;
    }

    public string GetPreco()
    {
        return Preco;
    }
)
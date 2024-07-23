namespace Diagamas;

public class Materia_Prima{
        Int64 Id;
        String Fornecedor;
        String Tipo;
        String Preco;
    
    public Materia_Prima()
    {
        
    }

    private void SetId(Int64 i)
    {
        Id = i;
    }

    public Int64 GetId()
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

    private void SetTipo(String t)
    {
        Tipo = t;
    }

    public string GetTipo()
    {
        return Tipo;
    }


    private void SetPreco(String p)
    {
        Preco = p;
    }

    public string GetPreco()
    {
        return Preco;
    }
}
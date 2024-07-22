using System.Security.Cryptography.X509Certificates;
using Microsoft.Maui.ApplicationModel.Communication;

namespace Diagamas;

public partial class Cliente(

    Public Cliente()
    {
        Int64 Id;
        String Nome;
        String Email;
        String Senha;
    }

    private void SetId(Int64 i)
    {
        Id = i;
    }

    public string GetId()
    {
        return Id;
    }

    private void SetNome(String n)
    {
        Nome = n;
    }

    public string GetNome()
    {
        return Nome;
    }

    private void SetEmail(String e)
    {
        Email = e;
    }

    public string GetEmail()
    {
        return Email;
    }


    private void SetSenha(String s)
    {
        Senha = s;
    }

    public string GetSenha()
    {
        return senha;
    }
)
using MinimalApi.Dominio.DTOs;
using MinimalApi.Dominio.Entidade;
using MinimalApi.Dominio.Interfaces;

namespace Test.Mocks;

public class AdministradorServicoMock : IAdministradorServico
{
    private static List<Administrador> administradores = new List<Administrador>()
    {
        new Administrador
        {
            Id = 1,
            Email = "adm@teste.com",
            Senha = "123456",
            Perfil = "Adm",
        },
        new Administrador
        {
            Id = 2,
            Email = "editor@teste.com",
            Senha = "1234abc",
            Perfil = "Editor"
        }
    };

    public Administrador? BuscarPorId(int id)
    {
        return administradores.Find(adm => adm.Id == id);
    }

    public Administrador Incluir(Administrador administrador)
    {
        administrador.Id = administradores.Count() + 1;
        administradores.Add(administrador);

        return administrador;
    }

    public Administrador? Login(LoginDTO loginDTO)
    {
        return administradores.Find(adm => adm.Email == loginDTO.Email && adm.Senha == loginDTO.Senha);
    }

    public List<Administrador> Todos(int? pagina)
    {
        return administradores;
    }
}
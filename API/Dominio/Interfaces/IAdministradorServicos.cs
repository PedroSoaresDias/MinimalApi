using MinimalApi.Dominio.DTOs;
using MinimalApi.Dominio.Entidade;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    Administrador Incluir(Administrador administrador);
    List<Administrador> Todos(int? pagina);
    Administrador? BuscarPorId(int id);
}
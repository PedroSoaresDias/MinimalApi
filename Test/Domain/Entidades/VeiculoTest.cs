using MinimalApi.Dominio.Entidade;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarPropriedadesDoVeiculo()
    {
        var veiculo = new Veiculo();

        veiculo.Id = 1;
        veiculo.Nome = "Supra";
        veiculo.Marca = "Toyota";
        veiculo.Ano = 2020;

        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Supra", veiculo.Nome);
        Assert.AreEqual("Toyota", veiculo.Marca);
        Assert.AreEqual(2020, veiculo.Ano);
    }
}
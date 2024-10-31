public class VeiculoDAO
{ 
    public List<Veiculo> listaVeiculo = new List<Veiculo>();

    public void Cadastrar(Veiculo v)
    { 
        listaVeiculo.Add(v);
    
    }

    public List<Veiculo> ListarTodos()
    { 
    
        return listaVeiculo;
    }

    public void Excluir(string placa)
    {
       Veiculo vExcluir = listaVeiculo.First(p => p.placa == placa);
        listaVeiculo.Remove(vExcluir);
    }

    public Veiculo Consultar(string placa)
    {
        Veiculo vConsult = listaVeiculo.First(p => p.placa == placa);
        return vConsult;
    }

}
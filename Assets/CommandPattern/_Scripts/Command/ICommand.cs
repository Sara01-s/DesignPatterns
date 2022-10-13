using System.Threading.Tasks;

namespace PatronesDeDiseño.CommandPattern {

    public interface ICommand {

        Task Execute();
    }
}

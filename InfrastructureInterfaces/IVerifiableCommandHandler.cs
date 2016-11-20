using System.Threading.Tasks;

namespace InfrastructureInterfaces
{
	/// <summary>
	/// ��������� ����������� ������ � �������������� ���������� ���������.
	/// </summary>
	/// <typeparam name="TCommand"></typeparam>
	public interface IVerifiableCommandHandler<TCommand> where TCommand : class
	{
		/// <summary>
		/// ������������ ���������� �������.
		/// </summary>
		/// <param name="command"></param>
		/// <returns>������ ��������� �������.</returns>
		Task<IVerifiableCommandHandlingResult> HandleAsync(TCommand command);
	}
}
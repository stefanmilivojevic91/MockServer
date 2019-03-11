using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.Shared
{
    public interface IUseCase<T1, T2>
    {
        Task<T2> Execute(T1 request);
    }
}

using AutoMapper;
using MediatR;
using Para.Base.Response;
using Para.Bussiness.Cqrs;
using Para.Data.Domain;
using Para.Data.UnitOfWork;
using Para.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para.Bussiness.Command
{
    internal class DeleteCustomerPhoneCommandHandler : IRequestHandler<DeleteCustomerPhoneCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public DeleteCustomerPhoneCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<ApiResponse> Handle(DeleteCustomerPhoneCommand request, CancellationToken cancellationToken)
        {
            await unitOfWork.CustomerPhoneRepository.Delete(request.CustomerPhoneId);
            await unitOfWork.Complete();
            return new ApiResponse();
        }
    }
}

using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>();
        CreateMap<CategoryDTO, Category>();
        CreateMap<CreateCategoryDTO, Category>();

        CreateMap<Product, ProductDTO>();
        CreateMap<ProductDTO, Product>();
        CreateMap<CreateProductDTO, Product>();

        CreateMap<Receiver, ReceiverDTO>();
        CreateMap<CreateReceiverDTO, Receiver>();

        CreateMap<Transaction, TransactionDTO>();
        CreateMap<CreateTransactionDTO, Transaction>();

        CreateMap<TransactionDetail, TransactionDetailDTO>();
        CreateMap<CreateTransactionDetailDTO, TransactionDetail>();
    }
}
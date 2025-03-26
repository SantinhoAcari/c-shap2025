using FluentValidation;

public class ProductValidator : AbstractValidator<CreateProductDTO> {
    public ProductValidator() {
        RuleFor(x => x.Name).NotNull().WithMessage("Nome é um campo obrigatório").NotEmpty().WithMessage("Nome não pode ser vazio");
        RuleFor(x => x.Quantity).NotNull().WithMessage("Quantidade é um campo obrigatório").GreaterThanOrEqualTo(0).WithMessage("Quantidade precisa ser maior ou igual a 0");
        RuleFor(x => x.CategoryId).NotNull().WithMessage("Categoria é um campo obrigatório").GreaterThan(0).WithMessage("Valor inválido");
    }
}
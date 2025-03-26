using FluentValidation;

public class TransactionDetailValidator : AbstractValidator<CreateTransactionDetailDTO> {
    public TransactionDetailValidator() {
        RuleFor(x => x.ProductId).NotNull().WithMessage("Produto é um campo obrigatório").GreaterThan(0).WithMessage("Valor inválido");
        RuleFor(x => x.TransactionId).NotNull().WithMessage("Transação é um campo obrigatório").GreaterThan(0).WithMessage("Valor inválido");
        RuleFor(x => x.Quantity).NotNull().WithMessage("Quantidade é um campo obrigatório").GreaterThan(0).WithMessage("Valor inválido");
    }
}
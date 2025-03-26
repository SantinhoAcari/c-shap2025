using FluentValidation;

public class TransactionValidator : AbstractValidator<CreateTransactionDTO> {
    public TransactionValidator() {
        RuleFor(x => x.Type).NotNull().WithMessage("Tipo é um campo obrigatório").NotNull().WithMessage("Nome não pode ser vazio").Must(type => type == "entry" || type == "exit").WithMessage("Tipo deve ser 'entry' ou 'exit'");
        RuleFor(x => x.ReceiverId).NotNull().WithMessage("Recebedor é um campo obrigatório").GreaterThan(0).WithMessage("Valor inválido");
    }
}
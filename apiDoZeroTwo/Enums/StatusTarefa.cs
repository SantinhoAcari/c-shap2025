﻿using System.ComponentModel;

namespace apiDoZeroTwo.Enums
{
    public enum StatusTarefa
    {
        [Description("A Fazer")] 
        AFazer = 1,

        [Description("Em Andamento")]
        EmAndamento = 2,

        [Description("Concluído")]
        Concluido = 3
    }
}

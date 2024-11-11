﻿namespace LomaNegra.Domain;

public record Hora(DateTime Value)
{
    public string GetHora => Value.ToShortTimeString();
}

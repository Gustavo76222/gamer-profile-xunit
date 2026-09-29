# 🎮 GamerProfile - Sistema de Perfil de Jogador

## 📌 Propósito do Sistema

O **GamerProfile** é um sistema simples para gerenciamento de perfis de jogadores.
Ele permite gerar tags de usuário, calcular XP total e verificar elegibilidade para partidas ranqueadas.

## 🧪 Testes Unitários Realizados

Foram implementados três tipos de testes unitários utilizando **xUnit**:

| # | Método Testado | Tipo de Retorno | Descrição |
|---|---|---|---|
| 1 | `GerarTagUsuario` | `string` | Valida a formatação correta da tag (Nickname#Código) |
| 2 | `CalcularXPTotal` | `int` | Valida a soma do XP de duas fases com bônus de 100 pontos |
| 3 | `EEligivelParaRanked` | `bool` | Valida se o jogador é elegível para Ranked (nível >= 15) |

## 🚀 Como Executar os Testes

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado

### Passos

1. Clone o repositório:
```bash
git clone https://github.com/Gustavo76222/gamer-profile-xunit.git
cd gamer-profile-xunit
Sistema GamerProfile com testes unitários usando xUnit

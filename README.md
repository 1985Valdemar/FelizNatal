# Mensagem de Feliz Natal com Animação e Música 🎄

Este projeto é um programa de console que exibe mensagens de Natal com animação de cores e reproduz uma música natalina em loop. 

## Funcionalidades
- Exibe mensagens animadas com diferentes cores.
- Reproduz uma música natalina em formato `.wav` (se o arquivo existir).
- Mensagem e animações configuráveis.

## Pré-requisitos
- .NET 8.0 ou superior instalado.
- Arquivo de música no formato `.wav` armazenado no diretório `Music` com o nome `MusicaNatal.wav`.

## Como funciona
1. O programa verifica se o arquivo de música (`Music\\MusicaNatal.wav`) existe:
   - **Se existir**, a música é reproduzida em loop enquanto a mensagem é exibida.
   - **Se não existir**, apenas a animação da mensagem é exibida.
2. A mensagem é animada com cores que mudam a cada linha, criando um efeito visual agradável.
3. O programa roda em um loop infinito até que o usuário o encerre manualmente.

## Estrutura do Código
- **`Main`**: Ponto de entrada. Gerencia a reprodução de música e chama a exibição das mensagens.
- **`DisplayMessage`**: Exibe as mensagens animadas com diferentes cores.
- **`messages`**: Array contendo as mensagens de Natal.
- **`colors`**: Array de cores usadas na animação.

## Como executar
1. Clone o repositório para sua máquina:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git


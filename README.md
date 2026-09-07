# 🚀 Meteor Dodge

Jogo 2D desenvolvido na Unity em que o jogador controla uma nave espacial e precisa desviar de meteoros que caem do céu.

O objetivo é sobreviver o maior tempo possível e conseguir a maior pontuação, evitando colisões com os meteoros.

## 🎮 Como jogar

- Use as **setas ← →** ou as teclas **A / D** para movimentar a nave.
- Desvie dos meteoros que caem pela tela.
- Cada meteoro que passar pela parte inferior da tela aumenta sua pontuação.
- Se a nave colidir com um meteoro, o jogo termina.
- Após o Game Over, clique em **"JOGAR NOVAMENTE"** para reiniciar a partida.

## ✨ Funcionalidades

- 🚀 Movimentação horizontal da nave
- ☄️ Meteoros surgindo aleatoriamente
- 💥 Detecção de colisão
- 🏆 Sistema de pontuação
- 🛑 Tela de Game Over
- 🔄 Botão para reiniciar a partida
- 🎵 Música de fundo
- ⏸️ Pausa do jogo ao ocorrer Game Over

## 🛠️ Tecnologias utilizadas

- **Unity**
- **C#**
- **Unity 2D**
- **TextMeshPro**
- **Rigidbody2D**
- **Collider2D**
- **Audio Source**

## 📂 Estrutura principal

```text
Assets/
├── Audio/
├── Prefabs/
├── Scenes/
├── Scripts/
└── ...
```

### Scripts principais

| Script | Responsabilidade |
|---|---|
| `PlayerMovement.cs` | Responsável pela movimentação horizontal da nave. |
| `MeteorSpawner.cs` | Responsável por criar os meteoros em posições aleatórias no topo da tela. |
| `Meteor.cs` | Controla o comportamento dos meteoros, a detecção de colisão com o jogador e o aumento da pontuação quando o meteoro sai da tela. |
| `GameManager.cs` | Controla o estado do jogo, pontuação, Game Over e reinicialização da partida. |

## ▶️ Como executar o projeto

1. Clone este repositório:

```bash
git clone https://github.com/giraldeli14/MeteorDodge
```

2. Abra o projeto pelo Unity Hub.
3. Abra a cena principal localizada na pasta:

```text
Assets/Scenes/
```

4. Clique em **Play ▶️** para iniciar o jogo.

## 🎯 Objetivo do projeto

O projeto foi desenvolvido como uma atividade prática de desenvolvimento de jogos 2D, aplicando conceitos de:

- Programação em C#
- Física 2D
- Detecção de colisões
- Instanciação de objetos
- Gerenciamento de cenas
- Interface gráfica (UI)
- Sistema de pontuação
- Reprodução de áudio

## 👩‍💻 Desenvolvimento

Projeto desenvolvido utilizando a Unity Engine e programação em C#.

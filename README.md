# RaycastBJ
Atividade com cena de demonstração de raycast, prefab e iluminação
nome: João Alfieri e Bruno Lima 

## PERSONAGEM

O personagem principal usa o modelo de capsula como corpo fisico, um dos codigos aplicados ao personagem é o de movimentação, perimitindo a se mover em todas as 4 direções com os botões "w,a,s,d", também é definida a velocidade que ele se movimenta e a gravidade aplicada, também colcamos uma mecanica de pulo que mexe no eixo y usando o botão space. Outro codigo ultilizado foi o da movimentação da camera que permite o jogador mover a camera de acordo com a movimentação do personagem.

![MicrosoftTeams-image (1)](https://github.com/Nikito-13/RaycastBJ/assets/101648676/ab81ad92-6a34-4557-b4e0-e264442331a1)

## INIMIGO

Os inimigos tambem usam o modelo de capsulas, eles tem como função principal serem reespawnados em outros lugares após o raycast deles serem ativado pelo player. 

![MicrosoftTeams-image (3)](https://github.com/Nikito-13/RaycastBJ/assets/101648676/bf1818d3-5015-45ee-a3ab-6d8ad4f025d5)

## RAYCAST

Como parte do raycast fizemos o sistema de colisão baseado em uma linha que ao clicar com o mouse na direção da linha ativa a colisão com o objeto, no nosso caso sendo atribuido a tag "inimigo" que ativa o script explicado anteriormente, o colocando em um lugar aleatorio dentro do "campo de tiro".


![MicrosoftTeams-image (2)](https://github.com/Nikito-13/RaycastBJ/assets/101648676/d5c458e9-a58a-4b1f-a4f8-2087397c32a1)

## ILUMINAÇÃO 

Para a parte de iluminação diminuimos a luminosidade total do ambiente para darmos mais enfase nas 3 light points que destacam os alvos, sendo elas 2 na area dos inimigos e uma perto do player para ele poder se ver. 

![MicrosoftTeams-image](https://github.com/Nikito-13/RaycastBJ/assets/101648676/a625459c-0f48-4f02-9c36-40b2ae9507a5)

# RaycastBJ
Atividade com cena de demonstração de raycast, prefab e iluminação
nome: João Alfieri e Bruno Lima 


## PERSONAGEM

O personagem principal usa o modelo de capsula como corpo fisico, um dos codigos aplicados ao personagem é o de movimentação, perimitindo a se mover em todas as 4 direções com os botões "w,a,s,d", também é definida a velocidade que ele se movimenta e a gravidade aplicada, também colcamos uma mecanica de pulo que mexe no eixo y usando o botão space. Outro codigo ultilizado foi o da movimentação da camera que permite o jogador mover a camera de acordo com a movimentação do personagem.

![Captura de tela 2023-06-14 080245](https://github.com/Nikito-13/RaycastBJ/assets/101647153/e9608b2a-ae31-4000-8447-af4733e0a415)

## INIMIGO

Os inimigos tambem usam o modelo de capsulas, eles tem como função principal serem reespawnados em outros lugares após o raycast deles serem ativado pelo player. 

![Captura de tela 2023-06-14 080148](https://github.com/Nikito-13/RaycastBJ/assets/101647153/ebe1d4e8-9c68-45cc-ab02-0e3ce75882a7)

## RAYCAST

Como parte do raycast fizemos o sistema de colisão baseado em uma linha que ao clicar com o mouse na direção da linha ativa a colisão com o objeto, no nosso caso sendo atribuido a tag "inimigo" que ativa o script explicado anteriormente, o colocando em um lugar aleatorio dentro do "campo de tiro".

![Captura de tela 2023-06-14 080633](https://github.com/Nikito-13/RaycastBJ/assets/101647153/3e3f641e-04ed-4182-8840-cfdaa959703b)

## ILUMINAÇÃO 

Para a parte de iluminação diminuimos a luminosidade total do ambiente para darmos mais enfase nas 3 light points que destacam os alvos, sendo elas 2 na area dos inimigos e uma perto do player para ele poder se ver. 

![Captura de tela 2023-06-14 075947](https://github.com/Nikito-13/RaycastBJ/assets/101647153/3c7f3299-4af2-4e43-b511-8982cd508e46)

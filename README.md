## Cron Job

A definição de uma cron job consiste em uma linha com 6 valores separados por espaço, assim:
    
    [segundo] [minuto] [hora] [dia-do-mes] [mes] [dia-da-semana] [ano]


<br>

##### Cron Job que rode todo dia as 06:00am:

    0 6 * * * [linha-de-comando]


##### Cron Job que rode as 12:30am de segunda e sexta:

    30 12 * * 1,5 [linha-de-comando]    


##### Cron Job que rode a meia-noite de três em três dias:

    0 0 */3 * * [linha-de-comando]    


##### Cron Job que rode todo dia a cada duas horas:

    0 */2 * * * [linha-de-comando]        


<br>


### A linha-de-comando

É um comando que você usaria normalmente para iniciar um script ou chamar um wget. 








<br>
<br>

##### Referências

<https://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/crontriggers.html>
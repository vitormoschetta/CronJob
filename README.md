## Cron Job

A definição de uma cron job consiste em uma linha com 6 valores separados por espaço, assim:
    
    [segundo] [minuto] [hora] [dia-do-mes] [mes] [dia-da-semana] [ano]


<br>

##### Cron Job que rode a cada 5 minutos:

    0 0/5 * * * ?


##### Cron que dispara às 10:30, 11:30, 12:30 e 13:30, todas as quartas e sextas-feiras:

    0 30 10-13 ? * WED,FRI    





<br>
<br>

##### Referências

<https://codigosimples.net/2014/12/15/criando-tarefas-agendadas-com-cron-jobs/>
<https://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/crontriggers.html>

# progress-task

This project demonstrates that where the Progress object is created affects what thread the progress handler runs on. 
When the Progress object is created on the UI thread, the handler runs on the UI thread. When Progress is created
on the Task thread, the handler runs on the Task thread (and requires more code to get back to the UI thread).

For more information, refer to this article: [Pay Attention to Where You Create Progress Objects](http://jeremybytes.blogspot.com/2015/07/pay-attention-to-where-you-create.html)

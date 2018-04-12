#include "stdafx.h"
#include "Kfifo.h"

void kfifo_test()
{
	uint8_t data[512] = { 0 };

	for (int i = 0; i < sizeof(data); i++)
	{
		data[i] = i;
	}
	Kfifo *kfifo = new Kfifo(sizeof(data));

	printf("FIFO创建成功，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
		kfifo->Size(), kfifo->Len(), kfifo->Avail());

	int write_len = kfifo->push(data, 200);
	printf("写入大小 %d\r\n", write_len);

	int read_len = kfifo->pop(data, 300);
	printf("读取大小 %d\r\n", read_len);
	if(1)
	{
		{
			if (kfifo->push(data, sizeof(data) / 2) > 0)
			{
				printf("FIFO写入成功，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFO写入失败，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO满了！！！\n");
			}
			else
			{
				printf("FIFO没满！！！\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO空了！！！\n");
			}
			else
			{
				printf("FIFO没空！！！\n");
			}
		}

		printf("\n");

		{
			uint8_t rdata[64] = { 0 };
			uint8_t len = kfifo->pop(rdata, sizeof(rdata));

			if (len > 0)
			{
				printf("从FIFO中读出的数据，长度：%d\n", len);

				for (int i = 0; i < len; i++)
				{
					printf("%d ", rdata[i]);
				}

				printf("\n");

				printf("FIFO读取成功，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFO读取失败，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO满了！！！\n");
			}
			else
			{
				printf("FIFO没满！！！\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO空了！！！\n");
			}
			else
			{
				printf("FIFO没空！！！\n");
			}
		}

		printf("\n");

		{
			kfifo->Reset();
			printf("FIFO清空成功，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
				kfifo->Size(), kfifo->Len(), kfifo->Avail());

			if (kfifo->IsFull() == true)
			{
				printf("FIFO满了！！！\n");
			}
			else
			{
				printf("FIFO没满！！！\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO空了！！！\n");
			}
			else
			{
				printf("FIFO没空！！！\n");
			}
		}

		printf("\n");

		{
			if (kfifo->push(data, sizeof(data)) > 0)
			{
				printf("FIFO写入成功，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFO写入失败，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO满了！！！\n");
			}
			else
			{
				printf("FIFO没满！！！\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO空了！！！\n");
			}
			else
			{
				printf("FIFO没空！！！\n");
			}
		}

		printf("\n");

		{
			if (kfifo->push(data, sizeof(data)) > 0)
			{
				printf("FIFO写入成功，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFO写入失败，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO满了！！！\n");
			}
			else
			{
				printf("FIFO没满！！！\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO空了！！！\n");
			}
			else
			{
				printf("FIFO没空！！！\n");
			}
		}

		printf("\n");

		{
			uint8_t  rdata[256] = { 0 };
			uint16_t len = kfifo->pop(rdata, sizeof(rdata));

			if (len > 0)
			{
				printf("从FIFO中读出的数据，长度：%d\n", len);

				for (int i = 0; i < len; i++)
				{
					printf("%d ", rdata[i]);
				}

				printf("\n");

				printf("FIFO读取成功，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFO读取失败，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO满了！！！\n");
			}
			else
			{
				printf("FIFO没满！！！\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO空了！！！\n");
			}
			else
			{
				printf("FIFO没空！！！\n");
			}
		}

		printf("\n");

		{
			uint8_t  rdata[256] = { 0 };
			uint16_t len = kfifo->pop(rdata, sizeof(rdata));

			if (len > 0)
			{
				printf("从FIFO中读出的数据，长度：%d\n", len);

				for (int i = 0; i < len; i++)
				{
					printf("%d ", rdata[i]);
				}

				printf("\n");

				printf("FIFO读取成功，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFO读取失败，FIFO大小：%d，使用大小：%d，剩余大小：%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO满了！！！\n");
			}
			else
			{
				printf("FIFO没满！！！\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO空了！！！\n");
			}
			else
			{
				printf("FIFO没空！！！\n");
			}
		}

		printf("\n\n\n");
	}
}
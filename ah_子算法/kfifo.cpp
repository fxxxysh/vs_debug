#include "stdafx.h"
#include "Kfifo.h"

void kfifo_test()
{
	uint8_t data[256] = { 0 };

	for (int i = 0; i < sizeof(data); i++)
	{
		data[i] = i;
	}
	Kfifo *kfifo = new Kfifo(sizeof(data));

	printf("FIFO�����ɹ���FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
		kfifo->Size(), kfifo->Len(), kfifo->Avail());

	if (kfifo->IsFull() == true)
	{
		printf("FIFO���ˣ�����\n");
	}
	else
	{
		printf("FIFOû��������\n");
	}

	if (kfifo->IsEmpty() == true)
	{
		printf("FIFO���ˣ�����\n");
	}
	else
	{
		printf("FIFOû�գ�����\n");
	}

	printf("\n");

	if(1)
	{
		{
			if (kfifo->push(data, sizeof(data) / 2) > 0)
			{
				printf("FIFOд��ɹ���FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFOд��ʧ�ܣ�FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû��������\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû�գ�����\n");
			}
		}

		printf("\n");

		{
			uint8_t rdata[64] = { 0 };
			uint8_t len = kfifo->pop(rdata, sizeof(rdata));

			if (len > 0)
			{
				printf("��FIFO�ж��������ݣ����ȣ�%d\n", len);

				for (int i = 0; i < len; i++)
				{
					printf("%d ", rdata[i]);
				}

				printf("\n");

				printf("FIFO��ȡ�ɹ���FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFO��ȡʧ�ܣ�FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû��������\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû�գ�����\n");
			}
		}

		printf("\n");

		{
			kfifo->Reset();
			printf("FIFO��ճɹ���FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
				kfifo->Size(), kfifo->Len(), kfifo->Avail());

			if (kfifo->IsFull() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû��������\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû�գ�����\n");
			}
		}

		printf("\n");

		{
			if (kfifo->push(data, sizeof(data)) > 0)
			{
				printf("FIFOд��ɹ���FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFOд��ʧ�ܣ�FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû��������\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû�գ�����\n");
			}
		}

		printf("\n");

		{
			if (kfifo->push(data, sizeof(data)) > 0)
			{
				printf("FIFOд��ɹ���FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFOд��ʧ�ܣ�FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû��������\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû�գ�����\n");
			}
		}

		printf("\n");

		{
			uint8_t  rdata[256] = { 0 };
			uint16_t len = kfifo->pop(rdata, sizeof(rdata));

			if (len > 0)
			{
				printf("��FIFO�ж��������ݣ����ȣ�%d\n", len);

				for (int i = 0; i < len; i++)
				{
					printf("%d ", rdata[i]);
				}

				printf("\n");

				printf("FIFO��ȡ�ɹ���FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFO��ȡʧ�ܣ�FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû��������\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû�գ�����\n");
			}
		}

		printf("\n");

		{
			uint8_t  rdata[256] = { 0 };
			uint16_t len = kfifo->pop(rdata, sizeof(rdata));

			if (len > 0)
			{
				printf("��FIFO�ж��������ݣ����ȣ�%d\n", len);

				for (int i = 0; i < len; i++)
				{
					printf("%d ", rdata[i]);
				}

				printf("\n");

				printf("FIFO��ȡ�ɹ���FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}
			else
			{
				printf("FIFO��ȡʧ�ܣ�FIFO��С��%d��ʹ�ô�С��%d��ʣ���С��%d\n",
					kfifo->Size(), kfifo->Len(), kfifo->Avail());
			}

			if (kfifo->IsFull() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû��������\n");
			}

			if (kfifo->IsEmpty() == true)
			{
				printf("FIFO���ˣ�����\n");
			}
			else
			{
				printf("FIFOû�գ�����\n");
			}
		}

		printf("\n\n\n");
	}
}
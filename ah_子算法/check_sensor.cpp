#include "stdafx.h"

#define _OK 0
#define _ERROR 1
#define max_sensors 8

class DrvIns
{
public:
	DrvIns() {};
	~DrvIns() {};

	DrvIns(int x)
	{
		val = x;
	}

	bool init()
	{
		printf("drv_ins init val = %d \r\n", val);

		if (val > 10)
			return _OK;
		else
			return _ERROR;
	}

	int val = 0;
};

// 排查错误传感器，正常传感器依次排列
void check_sensor()
{
	DrvIns *drv_ins[max_sensors];

	drv_ins[0] = new DrvIns(11);
	drv_ins[1] = new DrvIns(12);
	drv_ins[2] = new DrvIns(13);
	drv_ins[3] = new DrvIns(1);
	drv_ins[4] = new DrvIns(5);
	drv_ins[5] = new DrvIns(16);
	drv_ins[6] = new DrvIns(17);
	drv_ins[7] = new DrvIns(18);

	int allow_max_sensors = 0;
	for (int i = 0; i < max_sensors; i++)
	{
		DrvIns * ins = drv_ins[i];
		if (ins->init() == _OK)
		{
			drv_ins[allow_max_sensors++] = ins;
		}
	}

	printf("\r\ndrv_ins allow = %d\r\n", allow_max_sensors);
	for (int i = 0; i < allow_max_sensors; i++) {
		printf("drv_ins init val = %d \r\n", drv_ins[i]->val);
	}
}
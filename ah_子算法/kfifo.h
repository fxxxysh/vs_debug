
#include <stdint.h>

class Kfifo
{
#define min(a, b)  (((a) < (b)) ? (a) : (b))

public:
	Kfifo() {}
	virtual ~Kfifo()
	{
		delete[] _buffer;
	}

	Kfifo(uint32_t size)
	{
		_status = allocate(size);
	}

	bool allocate(uint32_t size)
	{
		if (is_power_of_2(size) != true)
		{
			size = roundup_pow_of_two(size);
		}

		if (_buffer != nullptr) {
			delete[] _buffer;
		}

		_buffer = new uint8_t[size];

		if (_buffer == nullptr) {
			return false;
		}

		_size = size;
		_in = 0;
		_out = 0;

		for (uint32_t index = 0; index < _size; index++) {
			_buffer[index] = {};
		}
		return true;
	}

	uint32_t push(uint8_t *buffer, uint32_t len)
	{
		len = min(len, _size - _in + _out);

		// 首先，将数据从_in开始放置到缓冲区端
		uint32_t l = min(len, _size - (_in & (_size - 1)));
		memcpy(_buffer + (_in & (_size - 1)), buffer, l);

		// 然后将其余的(如果有)放在缓冲区的开头
		memcpy(_buffer, buffer + l, len - l);

		_in += len;

		return len;
	}

	uint32_t pop(uint8_t *buffer, uint32_t len)
	{
		len = min(len, _in - _out);

		// 首先从_out获取数据，直到缓冲区结束
		uint32_t l = min(len, _size - (_out & (_size - 1)));
		memcpy(buffer, _buffer + (_out & (_size - 1)), l);

		// 从缓冲区的开头获取其余的(如果有)
		memcpy(buffer + l, _buffer, len - l);

		_out += len;

		return len;
	}

	// 判断是否为2的幂
	static bool is_power_of_2(uint32_t n)
	{
		return (n != 0 && ((n & (n - 1)) == 0));
	}

	// 将给定的值乘以最接近的二次方。
	static uint32_t roundup_pow_of_two(uint32_t n)
	{
		uint32_t b = 0;
		for (int i = 0; i < 32; i++)
		{
			b = 1UL << i;
			if (n <= b) {
				break;
			}
		}
		return b;
	}

	void Reset()
	{
		_in = 0;
		_out = 0;
	}

	uint32_t Size()
	{
		return _size;
	}

	uint32_t Len()
	{
		return _in - _out;
	}

	uint32_t Avail()
	{
		return Size() - Len();
	}

	bool IsEmpty()
	{
		return Len() == 0;
	}

	bool IsFull()
	{
		return Avail() == 0;
	}

	bool get_status()
	{
		return _status;
	}

public:
	uint8_t * _buffer;

private:
	bool _status;

	uint32_t _size;
	uint32_t _in;
	uint32_t _out;
};
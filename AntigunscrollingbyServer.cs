{$CLEO .cs}
0000:
:1
0001: wait 0 ms
0AFA:  is_samp_available 
004D: jump_if_false @1
0006: 0@ = 1
0BE3: raknet setup_incoming_rpc_hook @2
0BDE: pause_thread 0

:2
00D6: if
0039:   0@ == 1
004D: jump_if_false @3
0BE5: raknet 1@ = get_hook_param 1
00D6: if
0039:   1@ == 22
004D: jump_if_false @4
0BE5: raknet 2@ = get_hook_param 0
0BE7: raknet 3@ = bit_stream_read 2@ type 2

:4
00D6: if or
0039:   1@ == 67
0039:   1@ == 145
004D: jump_if_false @3
0BE0: raknet hook_ret 0

:3
0BE0: raknet hook_ret 1

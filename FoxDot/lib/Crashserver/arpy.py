from ... import Scale
from ..Patterns import P, Pattern

def PArp(seq, index=0):
    ### Return a arpeggiator Pattern from a dictionnary
    arp = []
    oc = len(Scale.default)   ### get octave length 
    k1 = k2 = k3 = k4 = P[seq[0]]  ### for different sequence lenght
    if len(seq) > 1: 
        k2 = P[seq[1]]
    if len(seq) > 2:    
        k3 = P[seq[2]]
    if len(seq) > 3:
        k4 = P[seq[3]]        
    ### Dict with {index: [[note_index], [nbr of octave]]} 
    arpdict = {
    # Standard Arp 3K
    0 : [[k1,k2,k3,k1, k2,k3,k1,k2, k3,k1,k2,k3, k1,k2,k3,k2], [0]],
    1 : [[k3,k2,k1,k3, k2,k1,k3,k2, k1,k3,k2,k1, k3,k2,k1,k2], [0]],
    2 : [[k1,k2,k3,k2, k1,k2,k3,k2, k1,k2,k3,k2, k1,k3,k1,k2], [0]],
    3 : [[k3,k2,k1,k2, k3,k2,k1,k2, k3,k2,k1,k2, k3,k2,k3,k1], [0]],
    4 : [[k2,k3,k1,k3, k2,k3,k1,k3], [0,-1,0,-1, 0,-1,0,-1]],
    5 : [[k1,k3,k2,k1, k1,k1,k2,k3], [-1,0,0,-1, 0,-1,0,0]],
    6 : [[k1,k1,k3,k1, k1,k2,k1,k3], [-1,-5,0,-1, 0,0,-1,0]],
    7 : [[k3,k1,k2,k1, k3,k1,k2,k1], [0]],
    8 : [[k3,k2,k1,k3, k2,k1,k3,k2], [0]], 
    9 : [[k1,k1,k1,k2, k1,k1,k1,k3], [-1,1,0,0, -1,1,0,0]],
    # More complex Arp 3K
    10 : [[k3,k2,k1,k3, k2,k1,k3,k2, k1,k3,k1,k3, k2,k1,k3,k2], [-1,0,0,-1, 0,0,-1,0, 0,-1,0,-1, 0,0,-1,0]],
    11 : [[k2,k1,k1,k3, k1,k1,k3,k1, k2,k1,k1,k3, k1,k1,k3,k1], [0,-1,0,0, -1,0,0,0]],
    12 : [[k2,k1,k1,k3, k1,k1,k3,k1, k2,k1,k1,k3, k1,k1,k3,k1], [0,-2,-1,0, -2,-1,0,-1, 0,-2,-1,0, -1,-2,0,-1]],
    13 : [[k1,k1,k1,k1, k1,k1,k1,k1, k2,k2,k1,k1, k1,k1,k1,k1], [0,0,-1,-5, -1,-5,0,0, 0,0,-1,-5, 0,0,-1,0]],
    14 : [[k1,k1,k2,k1, k1,k2,k1,k1, k2,k1,k1,k2, k1,k1,k2,k1], [-2,-1,0,-2, -1,0,-2,-1, 0,-2,-1,0, -2,-1,0,-1]],
    15 : [[k1,k1,k2,k3, k1,k1,k2,k3], [-1,0,0,0]],
    16 : [[k3,k1,k2,k1, k2,k1,k1,k3, k1,k1,k2,k1, k2,k1,k1,k1], [0,-2,0,-2, 0,-2,-1,0, -2,-1,0,-2, 0,-2,-1,-2]],
    17 : [[k3,k1,k2,k1, k1,k2,k1,k3, k1,k2,k1,k1, k2,k2,k1,k2], [0,-1,0,-2, -1,0,-2,0, -1,0,-2,-1, 0,0,-2,0]],
    # 2K Arp Scale
    20 : [[k1,k2+2,k2+3,k1, k2+5,k2+4,k1,k2, k2+2,k1,k2,k2+2, k1,k2+1,k1,k2], [-1,0,0,-1, 0,0,-1,0, 0,-1,0,0, -1,0,-1,0]],
    21 : [[k1,k1,k2+5,k1, k2+5,k1,k1,k2+4, k1,k1,k2+5,k1, k2+7,k1,k1,k2+4], [0,-1,0,-1, 0,0,-1,0, -1,0,0,-1, 0,-1,0,0]],
    22 : [[k1,k1,k2+5,k1, k2+5,k1,k1,k2+4, k1,k1,k2+5,k1, k2+7,k1,k1,k2+4], [-1,-1,0,-1, 0,-1,-1,0 ,-1,-1,0,-1, 0,-1,-1,0]],
    23 : [[k1,k1,k2+2,k1, k2+6,k1,k2+5,k1, k1,k2,k1,k1, k2+5,k1,k1,k2], [-1,0,0,-1, 0,-1,0,0, -1,0,-1,0, 0,-1,0,0]],
    # 3k Compldex Arp 32 steps
    30 : [[k1,k1,k2,k1, k3,k1,k1,k1, k2,k1,k3,k1, k1,k1,k2,k1, k3,k1,k1,k1, k2,k1,k3,k1, k1,k1,k2,k1, k3,k1,k3,k2], [0,-1,0,-1, 0,-1,0,-1, 0,-1,0,-1, 0,-1,0,-1,  0,-1,0,-1, 0,-1,0,-1, 0,-1,0,-1, 0,-1,0,0]],
    # 4K Arp
    40 : [[k1,k2,k3,k4, k2,k3,k4,k1, k3,k4,k1,k2, k4,k1,k2,k3], [0,0,0,0, 0,0,0,1, 0,0,1,1, 0,1,1,1]],
    41 : [[k4,k3,k2,k1, k3,k2,k1,k4, k2,k1,k4,k3, k1,k4,k3,k2], [1,1,1,1, 1,1,1,0, 1,1,0,0, 1,0,0,0]],
    42 : [[k1,k2,k3,k1, k3,k2,k3,k4, k1,k4,k3,k1, k1,k2,k1,k3], [-1,0,0,-1, 0,0,0,0, -1,0,0,-1, 0,0,-1,0]],
    43 : [[k1,k2,k3,k4, k2,k3,k4,k1, k3,k4,k1,k2, k4,k1,k2,k3, k3,k2,k1,k4, k2,k1,k4,k3, k1,k4,k3,k2, k4,k3,k2,k1], [0,0,0,0, 0,0,0,1, 0,0,1,1, 0,1,1,1, 1,1,1,0, 1,1,0,0, 1,0,0,0, 0,0,0,0]],
    44 : [[k1,k2,k1,k4, k2,(k2,k1),k3,k1, (k1,k1),k2,k1,(k1,k1), k2,k1,k3,k1], [-1,0,-1,-1, 0,(-1,-5),-1,-1, (-1,-5),0,-1,(-1,-5), 0,-1,0,-1]],
    # Simple Arp
    50 : [[k1,k2,k1,k1, k2,k1,k1,k1], [0,0,1,0, 0,1,0,1]],    
    51 : [[k1,k2,k3,k2+4, k1,k2+4, k3,k2], [0,0,0,0, 1,0,0,0]],
    52 : [[k1,k2,(k1,k2,k3),k2], [0]],    
    53 : [[k1,k2,k1,k3, k1,k2,k1,k1], [0,0,0,0, 0,0,0,1]],
    54 : [[k1,k2,k3,k1, k2,k1,k3,k1], [0,0,0,1, 0,0,0,1]],
    }
    if (index in arpdict):
    	arp = P[arpdict[index][0]] + P[arpdict[index][1]] * oc
    else:
    	arp = seq
    return Pattern(arp)
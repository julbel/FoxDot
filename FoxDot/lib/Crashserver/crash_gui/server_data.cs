�}q (X   server_dataq}q(X   lieuqX   TOPLAPqX   tmpsqX   16qX   langqX   english1qX   voiceq	X   0q
X	   bpm_introqX   48qX   scale_introqX   minorqX
   root_introqX   EqX   videoqKX   adresseqX   192.168.0.18quX   attack_dataq}q(X   connectq]q(X   Crash ServerqX�   Welcome CrAsh ServEr
C0nnect_the_S&rV3r
 -- StageLimiter : Active
 -- Carla : Active
 -- Record : Active
 -- Biniou : Active






















qXm   i3 >> sos(dur=8, lpf=linvar([60,4800],[tmps*1.5, tmps*3]), hpf=expvar([0,500],[tmps*6, tmps*2]))












qK eX   initq]q(X    qX   
















qX   














qKeX
   aspirationq ]q!(X
   Aspirationq"XE   Unknown connection. access denied.


































q#XB  b1 >> faim(g2.degree[0], dur=1/4, oct=3, kutoff=linvar([400,9900],[29,11]), amp=0.7, hpf=60) + var([0,P*[1,-1,2,-2]],[7,1])

g2 >> faim((var(PRand(-4,2),8),var(PRand(8),4)), dur=PDur(var([3,5,9],8),11), atk=[0.01,PWhite(0.01,0.03)], oct=(4), fx2=1, hpf=120, triode=1, krush=0, amp=PStrum()*0.5, kutoff=PRand(400,8400), amplify=1).sometimes("stutter", 1,oct=(5), drive=PWhite(0.2,0.4), dur=PRand(1,3)).unison(3)

y1 >> play("@", sample=PRand(10), amp=1, rate=PWhite(0.1,4), pan=PWhite(-1,1)).fill() 
d5 >> play("<W.[.W].><.+><..u.>", sample=2, amp=1)




























q$KeX	   attentionq%]q&(X	   Attentionq'X;   Memory overload, firewall activated.






















q(X�  Clock.bpm = 96;
l1 >> loop("cyborg8", sample=4, dur=8)

r1 >> rsin(dur=var(PRand([1,1/2,1/4,2]),8), hpf=linvar([30,180],23),oct=var([3, 4, 5], PRand(8)), para1=PWhite(200, 8000), fmod=8,lpf=linvar([3000,8000],19), sus=r1.dur+0.25)

i4 >> play("//", sample=PRand(1), room=1, mix=0.2, dur=16, hpf=40,amp=0.5, rate=[PWhite(-1,-0.1), PWhite(2,8)],pan=(PWhite(-1,1),PWhite(-1,1)))

w2 >> play("<|a3|.><(A.).><B><b.>", dur=2, sample=2, delay=(0,0.5),hpf=(40, 400, 100, 1000), hpr=0.2, formant=[1,0,2])

i2 >> play("i", dur=8, sample=6, leg=21, room=1, mix=0.2, echo=[(0.33,0.25), 0.25],mpf=12000).spread()

p1 >> pbass([0, 2, 3, 5, 7], dur=[1/2, 1/4, 1/2, 1/8, 1/8], oct=3, sus=0.1, spin=2).every(3, "degree.shuffle")

p4 >> play("<q ><p >", sample=1, dur=PDur([3, 5], 8), amp=0.5, chop=1/2, leg=PWhite(150), hpf=140)
p5 >> play("(qp) ", sample=2, dur=PDur([1, 6], 8), amp=0.8, leg=25)

d8 >> play("<X(..{XxK.})X(..X)(X.)>", sample=2,lpf=linvar([400,1500],[32,7]), lpr=PWhite(0.3,1), amp=0.7,amplify=1).every(PRand(1,9), "stutter", PRand([6,8,12,16]),rate=PWhite(1,1.125), pan=[-1,1], bpf=1500, drive=0.2)

c1 >> click(oct=[5,4], vib=[1, 2, 4, 8, 2, 16],echo=PStep([7,[3,6]],0,0.25), dur=[2,4,6], mult=PRand(16), amp=0.2,shape=0.2, slide=0.3, pan=PWhite(-1,1))
d8 >> play("<X(.....{X[XX]xv})><..O.><|x4|.>", amplify=1, lpf=8000)
dy >> play("<[-{---|+2|}]><..:>", sample=0, lpf=13000,pan=PWhite(-0.5,0.5),rate=PWhite(0.99,1.01)).human(80,3,4).sometimes("stutter", PRand(4))


















q)KeX	   corrosionq*]q+(X	   Corrosionq,X   




















q-X+  s3 >> star([0, 3, [3, 7], 0.5, PRand([3, 7, 0, (0.5, 3, 0)])], crush=linvar([128, 0], [16, inf], start=now),dur=1/8, oct=6, scale=Scale.locrianMajor, formant=PRand([0, 4]), amp=0.5) + Pvar([0, 3, 0, 0, 2, 0], [4, 2])
f1 >> faim(PArp([0,1,0.5],11), oct=(3, 4), dur=1/4, lpf=200)





















q.KeX
   absolutionq/]q0(X
   Absolutionq1X?   server in quarantine, the attack failed. Ah Ah Ah Ah!









q2X  Clock.bpm = linvar([120,150,120,60],[PRand([4, 8, 16, 2])])
p5 >> pianovel(Pvar([Scale.major, Scale.minor, Scale.locrian]).palindrome(), flanger=PWhite(0, 0.1), oct=P[3:7], lpf=Clock.bpm * 10, delay=(0, 0.5, 0.05), sus=PWhite(0.5,1.2), velocity=PWhite(40,80))








q3KeX   annihilationq4]q5(X   Annihilationq6X;   Defenses are broken. The server is vulnerable.












q7Xf  j1 >> play("j", sample=PRand(16), room=1, mix=0.5, amp=1, rate=(PSine(16)/100,-0.25), echo=1, echotime=4, drive=PWhite(0,0.1), chop=PWhite(0,4), dur=16, spf=1900, spfslide=4, spfend=4000).spread()
k5 >> play(PEuclid2(3,8,"X","|=2|"), sample=1,rate=var([1,0.7],[16,2]),lpf=linvar([800,5800],[24,0]), triode=PRand(16), lpr=linvar([1,0.05],[24,0])).often("stutter", Cycle([2,3,12]), amp=1, hpf=1800).sometimes("amen")
k6 >> play("X(---=)", amp=2, sample=var([1, 2], [14, 2]))
k7 >> play("<V(-[VX])V-><--(pu)->", sample=3, amp=var([0, 1], [3, 5]), hpf=45).every(7, "stutter", Cycle([2, 3, 1, 2, 3, 4]))















q8KeX   randomq9]q:(hX    random virus



















q;X   














q<KeX   42q=]q>(hX   


























q?X   





















q@KeX   43qA]qB(hX	   








qCX   




qDKeX	   desynchroqE]qF(X   !emiTqGX6   Alert! Time server desynchronization

















qHX    clip.copy(random_bpm())








qIKeX   sinqJ]qK(X	   -- Sin --qLX   












qMX  s5 >> sawbass(PSine(64)*0.5, oct=(4,5,6), dur=1, amp=0.7, sus=0.5, rq=0.7, hpf=100, cutoff=linvar([100,4800],64)).offbeat(0.25).unison(4,0.125).every(32, "oct.offadd", 1, 0.25)
n3 >> play("x.", dur=1/2, sample=4, amp=2, amplify=1, room=linvar([0.1,1],[42,0]), mix=expvar([0,0.4],16))
h4 >> play("-[--]-", amplify=1, sample=4, dur=1/2, amp=PBern(16)).spread()
n4 >> play("<k ><..c.>", sample=(3,3), amp=(2.5,1), hpf=60, lpf=3600, lpr=linvar([0.5,0.1],34)).sometimes("stutter", Cycle([2,3,4]), rate=PWhite(-0.1,4), hpf=380)












qNKeX   nucleoseqO]qP(X   @ Nucleose @qQX   














qRXa  a1 >> play("<X[--]><..O.>", amp=4, room=0.7, mix=PRand([0,.4,0])).sometimes("stutter", PRand(8))
s1 >> saw((0,1), oct=(3,[4,5]), lpf=PRand(8800), lpr=PWhite(0.1,0.9), amp=[0,0.4,0], dur=var([4,1/4,2],16), chop=8, drive=0.2, slide=(PWhite(-2,2),PWhite(-1,1))).unison(16, analog=40)
b1 >> dbass(PArp([0,2,-2], 13), dur=1/4, lpf=8000).unison(3)











qSKeX   gastroqT]qU(X   GastroqVX+   Buffer drain, in progress.
















qWXQ  dd >> play(P["Xx.xx.xx.xx.xx.x"], sample=(0,7,4), krush=3).sometimes("stutter")
ch >> play("#", dur=8, pan=(-1,1), amp=2, rate=[1,-1])
sn >> play("<--o(-[--])>", krush=3, lpf=9900, lpr=PWhite(0.2,0.8), sample=2, pan=PWhite(-1,1))
tt >> play("<[tt]t.t>", sample=PRand(5), pan=PWhite(-1,1), amp=var([0,1],[13,32,48]), amplify=[2.5,PWhite(0.8,2)]).sometimes("trim",2)
fi >> faim(var([-2,0],32), oct=PStep([8,4],[4,2,2],3), dur=1/4, amplify=(dd.degree=="x")*2*PBern(16)) + var([0,PRand([-1,1,0.5])],[7,1])
kk >> klank(PRand(8), dur=8, rate=linvar([0,1],[128]), amplify=1).unison(3)















qXKeX   zikaqY]qZ(X   Zikaq[X   












q\X  b2 >> dbass(p1.degree+PWhite(0,0.3), lpf=linvar([900,4500],24), dur=[1/2,1/4,1/2,1/4,1/2]).sometimes("dur.shuffle")
p1 >> prof(PSine(64)*0.2, oct=(var([(3,4),[5,6]],[6,2])), dur=PDur([5,7],8), sus=p1.dur*0.7, cutoff=7000, lforate=var([1,2,4],8), lfowidth=linvar([0.1,1],39), pan=[-1,1], amp=1.5)
n1 >> play("..I.", drive=(0,0.9), sample=1, rate=(PWhite(-1,4)), amp=PBern(16), pan=linvar([-1,1],24))
d4 >> play("x(---([::]:[::::]))", amp=3, sample=([0,1,2],[1,2,4])).sometimes("stutter")
d6 >> play("X ", amp=2)












q]KeX   syphyq^]q_(X   //+ SYPHY +//q`X   











qaX�  sq >> squish(oct=(3,[4,5]), dur=P*[8,4,2,1,0.5,0.125], echo=sq.dur/PRand([4,2,8]), echotime=sq.echo*PRand([1,2,0.5]), rate=PStep(8,PRand(40),1), triode=0.8, leg=4, lpf=4800, lpr=0.2, room=0.8, mix=0.1, amplify=0.2*PBern(24)).unison(5,0.2,80)
dd >> play("p", dur=1/4, amplify=PTimebin(), sample=PRand(1,4), bpf=linvar([200,4000],32), bpr=1, pan=P*[-1,1])
ds >> play("..O.", lpf=7800, shape=0.1, cut=1/2, sample=6, pan=(0.2,-0.2))
hh >> play("[--]", sample=4, cut=1/P[1:8], pan=PWhite(-1,1), bpf=linvar([1200,8080],36), bpr=PWhite(0.1,0.9), bpnoise=PRand(4)).human(50,-4)
dk >> play("<X.>", triode=(0,8,PRand(8)), sample=(6,3,2), amp=(2,0.5,0.7), lpf=(4800,PRand(120,1450),0), pshift=(-12,0,PRand(12))).sometimes("stutter")








qbKeX   slaapqc]qd(X!   /// SLAAP - DARKWATER - REMIX ///qeX   














qfX*	  Samples.addPath("/mnt/70225B03225ACDAA/CRASH SERVER/Production/Slaap - remix/zbdm version/")
Root.default="C"
Scale.default="minor"
Clock.bpm=176

w1 >> stretch("sl_wind", dur=P[16,32,64], sus=[32,64], lpf=1800, amp=0.2, rate=PWhite(-1,1)).unison(4)
w2 >> loop("sl_voice1", formant=1, dur=12, hpr=0.1, hpf=4000, amp=0.2, room=1, mix=0.6, pan=(-1,1))
w3 >> loop("sl_wind", 4, dur=6, sus=[12, 24], spin=[4, 8, 16, 2], hpr=0.1, hpf=0, amp=0.3, room=1, mix=0.4, pan=(-1,1))

w_all.stop()
g1 >> loop("sl_guit2", dur=32, shape=0)

g9 >> loop("sl_guit2", dur=[8,[16,4]], delay=[12,8,16,24], cut=[1/4,1/2,1/8], sus=16, chop=[16,32], room=0.3, mix=0.2, pan=(-1,1), crush=2)
l3 >> loop("sl_drum1", dur=32)
g3 >> loop("sl_guit3", dur=PRand([16,32]), chopwave=PRand(8), chop=PRand(8), room=1, mix=0.4, lpf=7800).unison(4)
g4 >> loop("sl_guit3", dur=PRand([8,16]), chopwave=PRand(8), chop=PRand(8), room=1, mix=0.4, lpf=7800).unison(4)

y1 >> loop("sl_voice2", dur=[16], shape=0.1, amplify=1).unison(0).after(16,"stop")
y2 >> loop("sl_voice3", dur=12, shape=0.2, amplify=1).after(12, "stop")
y3 >> loop("sl_voice1", dur=16, spin=0.4, amplify=PBern(8), room=1, mix=0.6).after(1, "stop")
y4 >> loop("sl_voice2", dur=15, spin=0.2, amplify=1, octafuz=1, room=1, mix=0.6).after(1, "stop")
y5 >> loop("sl_voice1", dur=14, spin=0.4, amp=PwRand([0, 1], [15, 1]), room=1, mix=0.6).after(1, "stop")

a1 >> play("x-", dur=1, sample=var(P[0:10],64), crush=0, amp=0.2).sometimes("stutter", PRand(8), rate=4).unison(5).sometimes("amen")
v_all.stop()
g_all.stop()
b1 >> loop("sl_bass1", dur=8, sus=8, shape=0.1, lpf=linvar([800,4800],[64,0]), lpr=PWhite(0,1)).unison(3)
b2 >> loop("sl_bass2", dur=16, shape=0.2, sus=16, amp=1.5, cut=[2/3,[0,1/3]], chop=[0,2,4]).unison(2)
b3 >> loop("sl_bass2", dur=16, lpf=800, sus=16)
k1 >> loop("sl_drum2", dur=32, lpf=4800)
k2 >> loop("fill4", sample=2, dur=8, hpf=4000)
k3 >> loop("fill4", sample=4, dur=8, hpf=2000)

b_all.stop()
y_all.stop()
k_all.stop()

p0 >> stretch("sl_guit1", pshift=-7, delay=8, dur=16, pan=-1)
p4 >> stretch("sl_guit1", pshift=-7, dur=8, pan=1)
p1 >> loop("sl_guit1", delay=4, dur=16, sus=32)
f1 >> loop("sl_guit1", dur=32)
p3 >> loop("sl_guit1", dur=16)

l4 >> loop("break16", sample=0, dur=16)
l5 >> loop("core16", sample=3, dur=16, chop=2, lpf=7800, amp=0.5)
l6 >> loop("core16", sample=2, dur=16)









qgKeX
   radiocrashqh]qi(X"   RadioHead - Fitter Happier - CoverqjX   



















qkX  Scale.default="major"
Root.default="Db"
Clock.bpm = 76
Clock.meter=(3,2)

i1 >> pluck((const(0), PRand(12).rnd(2), PRand(8)), rate=PWhite(0,1), atk=PWhite(0,4), oct=(3,4), dur=PRand(4,16), rel=PWhite(0,8), sus=16, decay=PWhite(0,8), blur=PRand(4), lpf=8000, triode=1, amp=1, room=1, mix=0.3).unison(3,linvar([0.02,0.25],128),99)
y1 >> play("K", sample=PRand(9), rate=(PWhite(-1,-0.3),PWhite(0.1,1)), dur=PRand(3,17), hpf=60, crush=4, room=1, mix=PWhite(0.4,0.7), lpf=1800, pan=(PWhite(-1,1),PWhite(-1,1)))

Voice(lyrics, lang="english", voice=2, rate=125)

p1 >> pianovel([var([(P*[-2,-9],0,5),PRand([(-2.5,-1,5),(-2.5,5),(-5,2.5,-1,5)])],[6,12]),-1,0,-1,0,-1,P*[0,-5],PwRand([5,6,3,-1,P+[5,6,3]],[3,3,3,3,1])], oct=(4.99,5.01), dur=[1,1,1,1,1/2,1/2,1/2,1/2], delay=PWhite(-0.025,0.025), lpf=var(PRand(800,2800),12), lpr=PWhite(0.4,0.8), velhard=PWhite(0.5,0.7), velocity=PRand(38,var([80,60],[1,5])), amplify=var([0,1],[PRand(6),PRand(24)]), room=1, mix=PWhite(0,0.4)).sometimes("stutter",amplify=1, velhard=(1, 0.1), oct=(5, 6), delay=0.125).sometimes("pivot", 5)

b3 >> pianovel(var([-2,0,5,[2,-4]],6), oct=3, dur=6, lpf=1200, hpf=100, velocity=PRand(70,80))
b1 >> faim(var([0,-4,-5,2],[12,12,6,6]), dur=PDur([[9,3],5],12), lpf=PRand(1200,3800), hpf=100, oct=PStep(6,4,3), amplify=PWhite(0.8,1.2)) + var([0,const([-2,2])],[5,1])
p9 >> donk((0, 0.5, [-0.5, 1]), delay=(0, 0.5, 0.75), dur=3, rate=P*[1, 2, 4, 8], room=PWhite(0.5,1), mix=PWhite(0.3,0.8), pan=(PWhite(-1,1),PWhite(-1,1)), hpf=PRand(60,580)).often("stutter").accompany(b1)

s1 >> dab(-2, dur=8, lpf=PRand(800,2000), fmod=PRand(8).rnd(2), oct=PStep(3,6,5), amp=0.5).every(4, "rotate").unison(3,0.25,99).after(8, "only")
d1 >> play("<K..><I...><..O.><[--]><.(.:)>", sample=P[0:9], amp=0.8, cut=PWhite(0,2), rate=(1,PWhite(-1,2))).sometimes("stutter", PRand(8)).every(16, "sample.rotate", PRand(8))
d2 >> play("<X.>", sample=1, amplify=2).every(4, "stutter", PRand(8))
n1 >> dafbass(linvar([0,0.3],[128,0]), dur=PDur([6,8,5],8), oct=[5,6], amplify=[0.5,0,d2.degree!="X",0.2,0.8], fmod=PRand([0,2,PRand(8)])).unison(3)

Voice(lyrics, lang="dirty", voice=4, rate=120)

lyrics = """Fitter. 
Happier.
More productive.
Comfortable.
Not drinking too much.
Regular exercise at the gym (3 days a week).
Getting on better with your associate employee contemporaries.
At ease.
Eating well (no more microwave dinners and saturated fats).
A patient, better driver.
A safer car (baby smiling in back seat).
Sleeping well (no bad dreams).
No paranoia.
Careful to all animals (never washing spiders down the plughole).
Keep in contact with old friends (enjoy a drink now and then).
Will frequently check credit at (moral) bank (hole in the wall).
Favours for favours.
Fond but not in love.
Charity standing orders.
On Sundays ring road supermarket.
(No killing moths or putting boiling water on the ants).
Car wash (also on Sundays).
No longer afraid of the dark or midday shadows.
Nothing so ridiculously teenage and desperate.
Nothing so childish.
At a better pace.
Slower and more calculated.
No chance of escape.
Now self-employed.
Concerned (but powerless).
An empowered and informed member of society (pragmatism not idealism).
Will not cry in public.
Less chance of illness.
Tyres that grip in the wet (shot of baby strapped in back seat).
A good memory.
Still cries at a good film.
Still kisses with saliva.
No longer empty and frantic.
Like a cat.
Tied to a stick.
That's driven into.
Frozen winter shit (the ability to laugh at weakness).
Calm.
Fitter. 
Healthier. and more productive.
A pig.
In a cage.
On antibiotics."""

















qlK	eX   --- SECOND PARTS ---qm]qn(hX   


qoX   


qpKeX   glitchqq]qr(hX   














qsX�   c1 >> glitcher(oct=PRand(8), rate=PWhite(1, 128), amp=1, dur=8, len=PWhite(1, 16), henA=PWhite(0.01, 4), fmod=0, henB=PWhite(0.1, 0.2), t=[2, 4, 6, 8, 32], crush=PRand(16),bits=16, shape=4.0).unison(2)











qtKeX   augmentationqu]qv(X   AugmentationqwX   




















qxX  g1 >> faim([2,3,[5,7]], slide=var([0,[-4,4]], [7,1]), leg=PWhite(0,4), sus=g1.dur*PWhite(0.2,1.5), oct=4, dur=([[1,1,1/2],2,1/2,4,1/2]*PRand([2,3,1,4])), hpf=60, chop=[0,4,16], amp=0.4, room=1, mix=PWhite(0.2,0.5)).spread().sometimes("shuffle") + (0,[2,[4,6]])




















qyKeX   consolationqz]q{(X   ? Consolation ?q|X#   Main core down. Instability







q}X�  Clock.bpm = 120
Root.default=12
var.cho = var(PMarkov(I),8)

t9 >> tb303(PArp(var.cho,5), oct=3, dur=1/4, top=linvar([200,10000],128), ctf=linvar([500,2000],[PRand(24,36),PRand(2,12)]), res=PWhite(0.1,0.3), sus=PStep(PRand(4,16)[:16],0.5,0.25), amp=0.35, lpf=9000, fx2=0).unison(3)
t9.lpf=linvar([20, 6000],[256, inf], start=now)
b4 >> dbass(var.cho[0], lpf=linvar([464,1664],13), hpf=0, amp=0.4, rate=linvar([0.01, 0.1], 128), dur=var([1/4,1/2],[6,2]), oct=(3,4)).unison(4)

d1 >> play("x.", feedfreq=[[0,PRand(500)],0], hpf=30, sample=4, amp=0.2, tanh=2, chop=1)
d1.feed=var(P*[0,0.125,0.25,0.5],16)

d7 >> play(P["x-(-m)"][:8].rotate(var([1,3])), rate=1.5, dur=1/4,amplify=0.8, delay=var([0,(0,0.75)],PRand(8)),sample=1)













q~KeX
   snowdationq]q�(X   :: snowdation ::q�X   




q�X�  Clock.bpm = 133;

a2 >> sine((0, 2), sinefb=linvar([0, 1.0], 128), amp=0.5, delay=0.5, oct=3, sus=2, hpf=200, pan=linvar([-1, 1], 128))
a4 >> sine((0, 2), sinefb=linvar([0, 0.5], 196), amp=0.3, delay=1, oct=3, sus=1, hpf=400, pan=linvar([1, -1], 128))
a1 >> play("U", dur=16, rate=[0.9, 1.1], sample=PRand([4, 5, 6, 7, 8, 9]), shape=0.1, feed=0.4).unison(2)
d8 >> play("p ", sample=4, rate=0.25, dur=16, delay=2, amp=4, echo=0.25, echotime=4)
d6 >> play("  c ", dur=8, amp=0.7, echo=0.5, room=1, mix=0.5)




q�K
eX   toplapq�]q�(X   TOPLAP Equinoxq�X�  At the dawn of an era of technological alienation, servers have taken control of almost all human data: identities, ways of thinking, DNA, ... Humanity seems at the mercy of these impalpable forces but a duo of computer machinists are fighting an endless battle against the central meta-brain. Their specialty, overheating and abducating audio servers with chaotic and random code lines. They are known as CRASH SERVER. This are their stories...








q�XG  cl >> click(0, dur=var([PDur(var(PRand(2,7),PRand(2,8)),8),8],[24,8]), hpf=40, drive=[PWhite(0.4,0.8),0.2], oct=(3, PStep(9,5,4)), octer=1, octersub=2, octersubsub=var([2, PRand(15,2222)], [15, 1]), triode=4, amp=0.1, amplify=1).unison(3).rarely("stutter",PRand(6), oct=6, pan=[-1,1], mpf=2860, hpf=400)
db >> bass(0, dur=c1.dur, leg=12, amp=var([0.5, 0], [12, 4]), rate=PWhite(0.01, 0.2), sus=db.dur*1.5).unison(2)
n1 >> play("<u><t>", sample=(2,P[0:5]), delay=(0,(0,[0,0.25])), dur=cl.dur, crush=[0,0,0,PRand(8)], bits=4, lpf=n1.crush*1500)








































q�Keuu.
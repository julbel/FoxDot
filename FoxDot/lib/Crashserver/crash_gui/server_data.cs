�}q (X   server_dataq}q(X   lieuqX   du diamand d'orqX   tmpsqX   16qX   langqX   frenchqX   voiceq	X   0q
X	   bpm_introqX   48qX   scale_introqX   minorqX
   root_introqX   EqX   videoqK X   adresseqX   192.168.0.22quX   attack_dataq}q(X   connectq]q(X   Crash ServerqXt   Welcome CrAsh ServEr
C0nnect_the_S&rV3r
 -- StageLimiter : Active
 -- Carla : Active
 -- Record : Active











qXb   i3 >> sos(dur=8, lpf=linvar([60,4800],[tmps*1.5, tmps*3]), hpf=expvar([0,500],[tmps*6, tmps*2]))

qK eX   initq]q(X    qX   






qX   




qKeX
   aspirationq ]q!(X
   Aspirationq"XB   Faille dans le serveur detectée, risque d'instabilité niveau 2

q#XA  b1 >> faim(var([-2,0],8), dur=1/4, oct=3, krush=[3,PWhite(0,3)], kutoff=linvar([400,9900],[29,11])) + var([0,P*[1,-1,2,-2]],[7,1])
b2 >> faim([3,PRand(7)], dur=PDur(9,11), oct=[[5,6],4], room=0.7, mix=0.3, krush=1.8, amp=PStrum(), kutoff=PRand(400,8400), amplify=var([[1,0,1],0],[16,8])).sometimes("stutter", drive=0.2).unison(4).penta()
sw >> pasha(b2.degree + (0,var(P*[6,3,2],4),4), amplify=[1,b2.amp>0.5], dur=PDur(7,9,2,var(P*[0.25,0.5,1],[6,2,4])), leg=PWhite(0,2), glide=PWhite(0.2,2), swell=0.4, sus=sw.dur*PWhite(0.1,0.9), oct=[5,6], room=1, mix=0.3).unison(4,0.125)

q$KeX	   attentionq%]q&(X	   Attentionq'XH   Attention, le server subit une attaque de classe 3, défense activée


q(X	  a1 >> rsin(dur=var(PRand([1,1/2,1/4,2]),8), hpf=linvar([30,180],23), oct=5, para1=PWhite(200, 8000), vib=4, fmod=8, lpf=linvar([3000,8000],19), sus=a1.dur+0.25)
q1 >> play("//", sample=PRand(1), room=1, mix=0.2, dur=16, hpf=40, spf=40, spfslide=5, spfend=8000, amp=0.5, rate=[PWhite(-1,-0.1), PWhite(2,8)], pan=(PWhite(-1,1),PWhite(-1,1)))
s2 >> play("<|a3|.><(A.).><B><b.>", dur=2, sample=2, delay=0.5, hpf=(40, 400, 100, 1000))
i2 >> play("i", dur=8, sample=6, leg=21, room=1, mix=0.2, echo=[(0.33, 0.25), 0.25],mpf=12000).spread()
g1 >> play("p ", sample=2, dur=1/2, lpf=7000, lpr=0.1, amplify=sinvar([0,1],37), amp=0.4, leg=8, pan=PWhite(-0.25,0.25))
g2 >> play("p ", sample=1, dur=PDur([3, 5], 8), lpf=8000, amplify=sinvar([0,1],13), lpr=0.3, amp=0.8, leg=8, pan=PWhite(0.5,-1))
g3 >> play("q ", sample=1, dur=PDur([3, 5], 8), amp=0.5, spf=8800, spfend=340, spfslide=2, chop=1/2, leg=PWhite(150), hpf=140, pshift=0, pan=PWhite(-0.4,0.7))
g4 >> play("q ", sample=2, dur=PDur([1, 6], 8), amp=0.8, leg=25, pan=PWhite(-1,1))
c2 >> cluster([0, 2, 0], para1=[14, 21, 28, 32, 128], mult=0, mpf=400, hpf=40, fmod=12, amp=1)
c3 >> cluster([0, 2, 0], oct=PStep(4,3,6), para1=[14, 21, 28, 32, 128], dur=4, hpf=40, mult=16, mpf=400, fmod=128, amp=1)
c4 >> cluster([0, 2, 0], para1=[14, 21, 28, 32, 128], dur=2, hpf=40, mult=4, mpf=400, fmod=12, amp=1)

d8 >> play("<X(..{XxK.})X(..X)(X.)>", sample=2, lpf=linvar([400,1500],[32,7]), lpr=PWhite(0.3,1), amp=0.7, amplify=1).every(PRand(1,9), "stutter", PRand([6,8,12,16]), rate=PWhite(1,1.125), pan=[-1,1], bpf=1500, drive=0.2)
c1 >> click(oct=[5,4], vib=[1, 2, 4, 8, 2, 16], echo=PStep([7,[3,6]],0,0.25), dur=[2,4,6], mult=PRand(16), amp=0.2, shape=0.2, slide=0.3, pan=PWhite(-1,1))

bd >> dbass(PSine(256)*0.3, dur=PDur(6,11), amplify=0.8*(d8.degree!="X"), leg=PRand(128), oct=5, lpf=3000, fx1=1, hpf=60).unison(3)

d8 >> play("<X(.....{X[XX]xv})><..O.><|x4|.>", amplify=1, lpf=8000)
dy >> play("<[-{---|:4|}]><.:>", sample=5, lpf=13000 ,pan=PWhite(-0.5,0.5), rate=PWhite(0.99,1.01)).human(80,3,4).sometimes("stutter", PRand(4))
s6 >> sawbass(bd.degree, dur=[6,2], oct=(4,[5,[6,7]]), leg=16, bend=([4,5],[3,2]), benddelay=([0.85,0.95,0.75],[0.65,1,0.35]), shape=PWhite(0,0.5), cutoff=linvar([2500,6000],24), amplify= 0.7, hpf=50, chop=var([0,4],[[6,14,2],[2,4]])).unison(3, 0.25, 80)




q)KeX	   corrosionq*]q+(X	   Corrosionq,X,   La base virale VPS a été mise à jour. 


q-X  s3 >> star([0, 3, [3, 7], 0.5, PRand([3, 7, 0, (0.5, 3, 0)])], crush=linvar([128, 0], [16, inf], start=now),dur=1/8, oct=6, scale=Scale.locrianMajor, formant=PRand([0, 4]), amp=0.5) + Pvar([0, 3, 0, 0, 2, 0], [4, 2])
f1 >> faim(PArp([0,1,0.5],11), oct=(3, 4), dur=1/4, lpf=200)



q.KeX
   absolutionq/]q0(X
   Absolutionq1XI   Le serveur est mis en quarataine, l'attaque a échouée. Ah Ah Ah Ah!



q2X  Clock.bpm = linvar([120,150,120,60],[PRand([4, 8, 16, 2])])
p5 >> pianovel(Pvar([Scale.major, Scale.minor, Scale.locrian]).palindrome(), flanger=PWhite(0, 0.1), oct=P[3:7], lpf=Clock.bpm * 10, delay=(0, 0.5, 0.05), sus=PWhite(0.5,1.2), velocity=PWhite(40,80))


q3KeX   annihilationq4]q5(X   Annihilationq6X:   Les défenses sont tombées. Le serveur est vulnérable


q7XZ  j1 >> play("j", sample=PRand(16), room=1, mix=0.5, amp=1, rate=(PSine(16)/100,-0.25), echo=1, echotime=4, drive=PWhite(0,0.1), chop=PWhite(0,4), dur=16, spf=1900, spfslide=4, spfend=4000).spread()
k5 >> play(PEuclid2(3,8,"X","|=2|"), sample=1,rate=var([1,0.7],[16,2]),lpf=linvar([800,5800],[24,0]), triode=PRand(16), lpr=linvar([1,0.05],[24,0])).often("stutter", Cycle([2,3,12]), amp=1, hpf=1800).sometimes("amen")
k6 >> play("X(---=)", amp=2, sample=var([1, 2], [14, 2]))
k7 >> play("<V(-[VX])V-><--(pu)->", sample=3, amp=var([0, 1], [3, 5]), hpf=45).every(7, "stutter", Cycle([2, 3, 1, 2, 3, 4]))



q8KeX   randomq9]q:(hX,   virus généré aléatoirement













q;X	   








q<KeX   42q=]q>(hX   























q?X   


















q@KeX   43qA]qB(hX   





qCX   

qDKeX	   desynchroqE]qF(X   !emiTqGX:   Alerte!, désynchronisation du serveur temporel










qHX   clip.copy(random_bpm())

qIKeX   sinqJ]qK(X	   -- Sin --qLX   






qMXK  t2 >> rsin(dur=8, para1=2500, chop=12, chopwave=PRand(8), chopmix=0.5, lpf=400, lpr=0.6)
t3 >> rsin(oct=(2,3), dur=PTri(5), vib=PRand(8), fmod=PRand([0,128,256,512]), para1=PWhite(-1050,2500), mpf=7500, coarse=t3.dur*16)
n3 >> play("x.", dur=1/2, sample=4, amp=2, amplify=1, room=linvar([0.1,1],[42,0]), mix=expvar([0,0.4],16))
h4 >> play("-[--]-", amplify=1, sample=4, dur=1/2, amp=PBern(16)).spread()
n4 >> play("<k ><..c.>", sample=(3,3), amp=(2.5,1), hpf=60, lpf=3600, lpr=linvar([0.5,0.1],34)).sometimes("stutter", Cycle([2,3,4]), rate=PWhite(-0.1,4), hpf=380)
h5 >> play("++:++", sample=PStep(8,0,2), octafuz=P[0:16]*0.1, rate=[-1,1,0.5], hpf=160).spread()
s5 >> sawbass(PSine(64)*0.5, oct=(4,5,6), dur=1, amp=0.4, sus=0.5, rq=0.7, hpf=100, cutoff=linvar([100,4800],64)).offbeat(0.25).unison(4,0.125).every(32, "oct.offadd", 1, 0.25)



qNK
eX   nucleoseqO]qP(X   @ Nucleose @qQX   






qRXY  a1 >> play("<X[--]><..O.>", amp=4, room=0.7, mix=PRand([0,.4,0])).sometimes("stutter", PRand(8))
s1 >> saw((0,1), oct=(3,[4,5]), lpf=PRand(8800), lpr=PWhite(0.1,0.9), amp=[0,0.4,0], dur=var([4,1/4,2],16), chop=8, drive=0.2, slide=(PWhite(-2,2),PWhite(-1,1))).unison(16, analog=40)
b1 >> dbass(PArp([0,2,-2], 13), dur=1/4, lpf=8000).unison(3)



qSKeX   gastroqT]qU(X   GastroqVX   




qWXB  dd >> play(P["Xx.xx.xx.xx.xx.x"], sample=(0,7,4), krush=3).sometimes("stutter")
ch >> play("#", dur=8, pan=(-1,1), amp=2, rate=[1,-1])
sn >> play("<--o(-[--])>", krush=3, lpf=9900, lpr=PWhite(0.2,0.8), sample=2, pan=PWhite(-1,1))
tt >> play("<[tt]t.t>", sample=PRand(5), pan=PWhite(-1,1), amp=var([0,1],[13,32,48]), amplify=[2.5,PWhite(0.8,2)]).sometimes("trim",2)
fi >> faim(var([-2,0],32), oct=PStep([8,4],[4,2,2],3), dur=1/4, amplify=(dd.degree=="x")*2*PBern(16)) + var([0,PRand([-1,1,0.5])],[7,1])
kk >> klank(PRand(8), dur=8, rate=linvar([0,1],[128]), amplify=1).unison(3)
qXKK eX   zikaqY]qZ(X   Zikaq[X   



q\X   b2 >> dbass(p1.degree+PWhite(0,0.3), lpf=linvar([900,4500],24), dur=[1/2,1/4,1/2,1/4,1/2]).sometimes("dur.shuffle")
p1 >> prof(PSine(64)*0.2, oct=(var([(3,4),[5,6]],[6,2])), dur=PDur([5,7],8), sus=p1.dur*0.7, cutoff=7000, lforate=var([1,2,4],8), lfowidth=linvar([0.1,1],39), pan=[-1,1], amp=1.5)
n1 >> play("..I.", drive=(0,0.9), sample=1, rate=(PWhite(-1,4)), amp=PBern(16), pan=linvar([-1,1],24))
d4 >> play("x(---([::]:[::::]))", amp=3, sample=([0,1,2],[1,2,4])).sometimes("stutter")
d6 >> play("X ", amp=2)

q]KK eX   syphyq^]q_(X   //* SYPHY *//q`X   



qaX�  sq >> squish(oct=(3,[4,5]), dur=P*[8,4,2,1,0.5,0.125], echo=sq.dur/PRand([4,2,8]), echotime=sq.echo*PRand([1,2,0.5]), rate=PStep(8,PRand(40),1), triode=0.8, leg=4, lpf=4800, lpr=0.2, room=0.8, mix=0.1, amplify=0.2*PBern(24)).unison(5,0.2,80)
dd >> play("p", dur=1/4, amplify=PTimebin(), sample=PRand(1,4), bpf=linvar([200,4000],32), bpr=1, pan=P*[-1,1])
ds >> play("..O.", lpf=7800, shape=0.1, cut=1/2, sample=6, pan=(0.2,-0.2))
hh >> play("[--]", sample=4, cut=1/P[1:8], pan=PWhite(-1,1), bpf=linvar([1200,8080],36), bpr=PWhite(0.1,0.9), bpnoise=PRand(4)).human(50,-4)
dk >> play("<X.>", triode=(0,8,PRand(8)), sample=(6,3,2), amp=(2,0.5,0.7), lpf=(4800,PRand(120,1450),0), pshift=(-12,0,PRand(12))).sometimes("stutter")
qbKK eX   ebolaqc]qd(X   ~~~ EBOLA ~~~qeX
   









qfX   cl >> click(dur=PDur(var(PRand(2,7),PRand(2,8)),8), hpf=40, drive=linvar([.1,0.3],64), oct=(3,4), octer=1, octersub=2, octersubsub=var([2, 2222], [15, 1]), triode=4, amplify=0.8).unison(4).sometimes("stutter",PRand(16), oct=6, pan=[-1,1])
db >> bass([[0,2,-1],0,0,4], dur=cl.dur, lpf=[0,PRand(900,4500)], leg=[0,2], hpf=60).penta() + var([0,PRand(7)],[6,2])
pr >> prophet(db.degree, glide=pr.sus*cl.dur, dur=6, sus=8, oct=P*[4,5,6,7], chop=PRand(0,8).rnd(2), amplify=0.6, drive=0.1, hpf=300, mpf=8080).unison(3,0.5,80)
d2 >> play("<xd>", sample=[7,1], amp=3, dur=cl.dur, pan=[0,[-1,1]]).sometimes("stutter")
d3 >> play("<X-><..O.>", amp=3, sample=0, crush=0)
d3 >> play("<X(.[XX].X){..[.X].}(..X)><..O{..([.O].{[.O.][..O][OOO]})}><[-]:>", sample=(1,5,4), crush=4)




qgKeX   slaapqh]qi(X!   /// SLAAP - DARKWATER - REMIX ///qjX	   








qkX$	  Samples.addPath("/mnt/70225B03225ACDAA/CRASH SERVER/Production/Slaap - remix/zbdm version/")
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

v1 >> loop("sl_voice2", dur=[16], shape=0.1, amplify=1).unison(0).after(16,"stop")
v2 >> loop("sl_voice3", dur=12, shape=0.2, amplify=1).after(12, "stop")
v3 >> loop("sl_voice1", dur=16, spin=0.4, amplify=PBern(8), room=1, mix=0.6).after(1, "stop")
v4 >> loop("sl_voice2", dur=15, spin=0.2, amplify=1, octafuz=1, room=1, mix=0.6).after(1, "stop")
v5 >> loop("sl_voice1", dur=14, spin=0.4, amp=PwRand([0, 1], [15, 1]), room=1, mix=0.6).after(1, "stop")

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
v_all.stop()
k_all.stop()

p0 >> stretch("sl_guit1", pshift=-7, delay=8, dur=16, pan=-1)
p4 >> stretch("sl_guit1", pshift=-7, dur=8, pan=1)
p1 >> loop("sl_guit1", delay=4, dur=16, sus=32)
f1 >> loop("sl_guit1", dur=32)
p3 >> loop("sl_guit1", dur=16)

l4 >> loop("break16", sample=0, dur=16)
l5 >> loop("core16", sample=3, dur=16, chop=2, lpf=7800, amp=0.5)
l6 >> loop("core16", sample=2, dur=16)



qlKK eX
   radiocrashqm]qn(X"   RadioHead - Fitter Happier - CoverqoX   







qpX  Scale.default="major"
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





qqKeX   --- SECOND PARTS ---qr]qs(hX   


qtX   


quK	eX   glitchqv]qw(hX   






qxX�   c1 >> glitcher(oct=PRand(8), rate=PWhite(1, 128), amp=1, dur=8, len=PWhite(1, 16), henA=PWhite(0.01, 4), fmod=0, henB=PWhite(0.1, 0.2), t=[2, 4, 6, 8, 32], crush=PRand(16),bits=16, shape=4.0).unison(2)



qyKeX   bitteqz]q{(X   BITTE ACHT BITS IIq|XI  Dans l'épisode précédent, les CrashServer vinrent à bout du server diamand de manière brutale. Bien trop impétueux pour réaliser que celui ci s'était sauvegardé à temps, dans le réseau. Quelques gigaoctets plus tard, ils reviennent pour une lutte qui s'annonce bien plus sanglante. Voici leur histoire.















q}X
  cl >> click(dur=PDur(var(PRand(2,7),PRand(2,8)),8), hpf=40, drive=linvar([.1,0.3],64), oct=(3,4), octer=1, octersub=2, octersubsub=var([2, 2222], [15, 1]), triode=4, amplify=0.8).unison(4).sometimes("stutter",PRand(16), oct=6, pan=[-1,1])
db >> bass([[0,2,-1],0,0,4], dur=cl.dur, lpf=[0,PRand(900,4500)], leg=[0,2], hpf=60).penta() + var([0,PRand(7)],[6,2])
pr >> prophet(db.degree, glide=pr.sus*cl.dur, dur=6, sus=8, oct=P*[4,5,6,7], chop=PRand(0,8).rnd(2), amplify=0.6, drive=0.1, hpf=300, mpf=8080).unison(3,0.5,80)
d2 >> play("<xd>", sample=[7,1], amp=3, dur=cl.dur, pan=[0,[-1,1]]).sometimes("stutter")
d3 >> play("<X-><..O.>", amp=3, sample=0, crush=0)
d3 >> play("<X(.[XX].X){..[.X].}(..X)><..O{..([.O].{[.O.][..O][OOO]})}><[-]:>", sample=(1,5,4), crush=4)














q~KeX   augmentationq]q�(X   Augmentationq�X   











q�X  g1 >> faim([2,3,[5,7]], slide=var([0,[-4,4]], [7,1]), leg=PWhite(0,4), sus=g1.dur*PWhite(0.2,1.5), oct=4, dur=([[1,1,1/2],2,1/2,4,1/2]*PRand([2,3,1,4])), hpf=60, chop=[0,4,16], amp=0.4, room=1, mix=PWhite(0.2,0.5)).spread().sometimes("shuffle") + (0,[2,[4,6]])











q�Keuu.
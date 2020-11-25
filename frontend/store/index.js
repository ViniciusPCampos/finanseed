export const state = () => ({
  transactions: [
    {
      title: 'Corujão Lanches',
      value: 900,
      category: 'Alimentação',
      date: '2020-11-03',
      parcel: 'Á vista',
      tags: ['lanche noturno'],
      type: 'Entrada'
    },
    {
      title: 'Corujão Lanches',
      value: 900,
      category: 'Alimentação',
      date: '2020-11-03',
      parcel: 'Á vista',
      tags: ['lanche noturno'],
      type: 'Saída'
    },
    { title: 'fsdfgsdfsadfa', value: 250, date: '2020-11-03', type: 'Entrada', parcel: 'Á vista', category: 'Educação', tags: ['Lanche', 'Casa', 'Carro'] }
  ]
})

export const mutations = {
  addTransaction (state, payload) {
    state.transactions.push(payload)
  }
}

export const getters = {
  transactions (state) {
    return state.transactions
  }
}

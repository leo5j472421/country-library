<template>
  <div class="container">
    <form @submit.prevent="onSubmit">
      <input type="text" v-model="editedCountry.name" placeholder="國家名稱">
      <button type="submit">儲存</button>
    </form>
  </div>
</template>

<script>
export default {
  name: 'EditCountry',
  props: {
    country: {
      type: Object,
      required: true,
    },
  },
  data() {
    return {
      editedCountry: { ...this.country },
    };
  },
  methods: {
    onSubmit() {
      this.$emit('onEdit', this.editedCountry);
    },
  },
};
</script>